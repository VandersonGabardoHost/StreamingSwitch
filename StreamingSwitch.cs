using NAudio.Gui;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace StreamingSwitch
{
    public partial class StreamingSwitch : Form
    {
        static readonly Timer temporizadorgeral = new Timer();
        bool streamdois = false;
        private BufferedWaveProvider provedordebuffer1;
        private BufferedWaveProvider provedordebuffer2;
        private IWavePlayer saidadeaudiowave1;
        private IWavePlayer saidadeaudiowave2;
        private volatile StreamingPlaybackState estadodoplay1;
        private volatile StreamingPlaybackState estadodoplay2;
        private volatile bool fullyDownloaded1;
        private HttpWebRequest requisicaodaweb1;
        private volatile bool fullyDownloaded2;
        private HttpWebRequest requisicaodaweb2;
        private VolumeWaveProvider16 provedordevolumedeaudio1;
        private VolumeWaveProvider16 provedordevolumedeaudio2;
        delegate void ShowErrorDelegate(string message);
        public StreamingSwitch()
        {
            InitializeComponent();

            lblTitulo.Text = "Streaming Switch By GabardoHost";

            ListaDispositivos();
        }

        public void Audio2()
        {
            if (estadodoplay2 == StreamingPlaybackState.Stopped)
            {
                estadodoplay2 = StreamingPlaybackState.Buffering;
                provedordebuffer2 = null;
                System.Threading.ThreadPool.QueueUserWorkItem(Stream2Mp3, txtUrl2.Text);
                tgA2.Enabled = true;
            }
            else if (estadodoplay2 == StreamingPlaybackState.Paused)
            {
                estadodoplay2 = StreamingPlaybackState.Buffering;
            }
        }

        public void Audio1()
        {
            if (estadodoplay1 == StreamingPlaybackState.Stopped)
            {
                estadodoplay1 = StreamingPlaybackState.Buffering;
                provedordebuffer1 = null;
                System.Threading.ThreadPool.QueueUserWorkItem(Stream1Mp3, txtUrl1.Text);
                tgA1.Enabled = true;
            }
            else if (estadodoplay1 == StreamingPlaybackState.Paused)
            {
                estadodoplay1 = StreamingPlaybackState.Buffering;
            }
        }

        private void BtnAudio1_Click(object sender, EventArgs e)
        {
            try
            {
                streamdois = false;
                ValidacoesGerais();
                Audio1();
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAudioparar1_Click(object sender, EventArgs e)
        {
            try
            {
                streamdois = false;
                if (estadodoplay1 == StreamingPlaybackState.Playing || estadodoplay1 == StreamingPlaybackState.Buffering)
                {
                    saidadeaudiowave1.Pause();
                    // Debug.WriteLine(String.Format("User requested Pause, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                    estadodoplay1 = StreamingPlaybackState.Paused;
                }
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void BtnPararcomplet1_Click(object sender, EventArgs e)
        {
            try
            {
                streamdois = false;
                StopPlayback();
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAudio2_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacoesGerais();
                streamdois = true;
                Audio2();
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAudioparar2_Click(object sender, EventArgs e)
        {
            try
            {
                streamdois = true;
                if (estadodoplay2 == StreamingPlaybackState.Playing || estadodoplay2 == StreamingPlaybackState.Buffering)
                {
                    saidadeaudiowave2.Pause();
                    // Debug.WriteLine(String.Format("User requested Pause, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                    estadodoplay2 = StreamingPlaybackState.Paused;
                }
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void BtnPararcomplet2_Click(object sender, EventArgs e)
        {
            try
            {
                streamdois = true;
                StopPlayback();
            }
            catch (Exception ex)
            {
                // Exibe exceção bruta de sistema caso não tenha mensagem personalizada
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void ShowError(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowErrorDelegate(ShowError), message);
            }
            else
            {
                MessageBox.Show(message, "Erro do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        enum StreamingPlaybackState
        {
            Stopped,
            Playing,
            Buffering,
            Paused
        }

        private void Stream1Mp3(object state)
        {
            try
            {
                fullyDownloaded1 = false;
                var url = (string)state;
                requisicaodaweb1 = (HttpWebRequest)WebRequest.Create(url);
                requisicaodaweb1.UserAgent = "GabardoHost GET URL";
                HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)requisicaodaweb1.GetResponse();
                }
                catch (WebException e)
                {
                    if (e.Status != WebExceptionStatus.RequestCanceled)
                    {
                        ShowError(e.Message + e.StackTrace);
                    }
                    return;
                }
                var buffer = new byte[16384 * 4]; // needs to be big enough to hold a decompressed frame

                IMp3FrameDecompressor decompressor = null;
                try
                {
                    using (var responseStream = resp.GetResponseStream())
                    {
                        var readFullyStream = new ReadFullyStream(responseStream);
                        do
                        {
                            if (IsBufferNearlyFull1)
                            {
                                //Debug.WriteLine("Buffer getting full, taking a break");
                                System.Threading.Thread.Sleep(500);
                            }
                            else
                            {
                                Mp3Frame frame;
                                try
                                {
                                    frame = Mp3Frame.LoadFromStream(readFullyStream);
                                }
                                catch (EndOfStreamException)
                                {
                                    fullyDownloaded1 = true;
                                    // reached the end of the MP3 file / stream
                                    break;
                                }
                                catch (WebException)
                                {
                                    // probably we have aborted download from the GUI thread
                                    break;
                                }
                                if (frame == null)
                                    break;
                                if (decompressor == null)
                                {
                                    // don't think these details matter too much - just help ACM select the right codec
                                    // however, the buffered provider doesn't know what sample rate it is working at
                                    // until we have a frame
                                    decompressor = CreateFrameDecompressor(frame);
                                    provedordebuffer1 = new BufferedWaveProvider(decompressor.OutputFormat);
                                    provedordebuffer1.BufferDuration = TimeSpan.FromSeconds(int.Parse(txtBuffer1.Text));
                                    // allow us to get well ahead of ourselves this.bufferedWaveProvider.BufferedDuration = 250;
                                }
                                int decompressed = decompressor.DecompressFrame(frame, buffer, 0);
                                //Debug.WriteLine(String.Format("Decompressed a frame {0}", decompressed));
                                provedordebuffer1.AddSamples(buffer, 0, decompressed);
                            }
                        }
                        while (estadodoplay1 != StreamingPlaybackState.Stopped);
                        // Debug.WriteLine("Exiting");
                        // was doing this in a finally block, but for some reason
                        // we are hanging on response stream .Dispose so never get there
                        decompressor.Dispose();
                    }
                }
                finally
                {
                    if (decompressor != null)
                    {
                        decompressor.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void Stream2Mp3(object state)
        {
            try
            {
                fullyDownloaded2 = false;
                var url = (string)state;
                requisicaodaweb2 = (HttpWebRequest)WebRequest.Create(url);
                requisicaodaweb2.UserAgent = "GabardoHost GET URL";
                HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)requisicaodaweb2.GetResponse();
                }
                catch (WebException e)
                {
                    if (e.Status != WebExceptionStatus.RequestCanceled)
                    {
                        ShowError(e.Message + e.StackTrace);
                    }
                    return;
                }
                var buffer2 = new byte[16384 * 4]; // needs to be big enough to hold a decompressed frame

                IMp3FrameDecompressor decompressor2 = null;
                try
                {
                    using (var responseStream = resp.GetResponseStream())
                    {
                        var readFullyStream = new ReadFullyStream(responseStream);
                        do
                        {
                            if (IsBufferNearlyFull2)
                            {
                                //Debug.WriteLine("Buffer getting full, taking a break");
                                System.Threading.Thread.Sleep(500);
                            }
                            else
                            {
                                Mp3Frame frame;
                                try
                                {
                                    frame = Mp3Frame.LoadFromStream(readFullyStream);
                                }
                                catch (EndOfStreamException)
                                {
                                    fullyDownloaded2 = true;
                                    // reached the end of the MP3 file / stream
                                    break;
                                }
                                catch (WebException)
                                {
                                    // probably we have aborted download from the GUI thread
                                    break;
                                }
                                if (frame == null)
                                    break;
                                if (decompressor2 == null)
                                {
                                    // don't think these details matter too much - just help ACM select the right codec
                                    // however, the buffered provider doesn't know what sample rate it is working at
                                    // until we have a frame
                                    decompressor2 = CreateFrameDecompressor(frame);
                                    provedordebuffer2 = new BufferedWaveProvider(decompressor2.OutputFormat);
                                    provedordebuffer2.BufferDuration = TimeSpan.FromSeconds(int.Parse(txtBuffer2.Text));
                                    // allow us to get well ahead of ourselves this.bufferedWaveProvider.BufferedDuration = 250;
                                }
                                int decompressed2 = decompressor2.DecompressFrame(frame, buffer2, 0);
                                //Debug.WriteLine(String.Format("Decompressed a frame {0}", decompressed));
                                provedordebuffer2.AddSamples(buffer2, 0, decompressed2);
                            }
                        }
                        while (estadodoplay2 != StreamingPlaybackState.Stopped);
                        // Debug.WriteLine("Exiting");
                        // was doing this in a finally block, but for some reason
                        // we are hanging on response stream .Dispose so never get there
                        decompressor2.Dispose();
                    }
                }
                finally
                {
                    if (decompressor2 != null)
                    {
                        decompressor2.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private static IMp3FrameDecompressor CreateFrameDecompressor(Mp3Frame frame)
        {
            WaveFormat waveFormat = new Mp3WaveFormat(frame.SampleRate, frame.ChannelMode == ChannelMode.Mono ? 1 : 2,
                frame.FrameLength, frame.BitRate);
            return new AcmMp3FrameDecompressor(waveFormat);
        }

        private bool IsBufferNearlyFull1
        {
            get
            {
                return provedordebuffer1 != null && provedordebuffer1.BufferLength - provedordebuffer1.BufferedBytes < provedordebuffer1.WaveFormat.AverageBytesPerSecond / 4;
            }
        }

        private bool IsBufferNearlyFull2
        {
            get
            {
                return provedordebuffer2 != null && provedordebuffer2.BufferLength - provedordebuffer2.BufferedBytes < provedordebuffer2.WaveFormat.AverageBytesPerSecond / 4;
            }
        }

        private void TgA1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (estadodoplay1 != StreamingPlaybackState.Stopped)
                {
                    if (saidadeaudiowave1 == null && provedordebuffer1 != null)
                    {
                        int dispositivoid = lstDispos.SelectedIndex;
                        // Debug.WriteLine("Creating WaveOut Device");
                        saidadeaudiowave1 = CreateWaveOut();
                        saidadeaudiowave1.PlaybackStopped += OnPlaybackStopped;
                        provedordevolumedeaudio1 = new VolumeWaveProvider16(provedordebuffer1);
                        provedordevolumedeaudio1.Volume = new VolumeSlider().Volume;
                        provedordevolumedeaudio1.Volume = regVol1.Volume;
                        if (dispositivoid != -1)
                        {
                            dispositivoid = dispositivoid - 1;
                        }
                        saidadeaudiowave1 = new WaveOutEvent() { DeviceNumber = dispositivoid };
                        saidadeaudiowave1.Init(provedordevolumedeaudio1);
                        pbBuf1.Maximum = (int)provedordebuffer1.BufferDuration.TotalMilliseconds;
                    }
                    else if (provedordebuffer1 != null)
                    {
                        var bufferedSeconds = provedordebuffer1.BufferedDuration.TotalSeconds;
                        streamdois = false;
                        ShowBufferState(bufferedSeconds);
                        // make it stutter less if we buffer up a decent amount before playing
                        if (bufferedSeconds < 0.5 && estadodoplay1 == StreamingPlaybackState.Playing && !fullyDownloaded1)
                        {
                            // Pause();
                            StopPlayback();
                            System.Threading.Thread.Sleep(5000);
                            Audio1();
                        }
                        else if (bufferedSeconds > 4 && estadodoplay1 == StreamingPlaybackState.Buffering)
                        {
                            Play();
                        }
                        else if (fullyDownloaded1 && bufferedSeconds == 0)
                        {
                            // Debug.WriteLine("Reached end of stream");
                            StopPlayback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private IWavePlayer CreateWaveOut()
        {
            return new WaveOut();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Debug.WriteLine("Playback Stopped");
            if (e.Exception != null)
            {
                MessageBox.Show(String.Format("Playback Error {0}", e.Exception.Message));
            }
        }

        private void Pause()
        {
            if (streamdois == false)
            {
                estadodoplay1 = StreamingPlaybackState.Buffering;
                saidadeaudiowave1.Pause();
                // Debug.WriteLine(String.Format("Paused to buffer, waveOut.PlaybackState={0}", waveOut.PlaybackState));
            }
            if (streamdois == true)
            {
                estadodoplay2 = StreamingPlaybackState.Buffering;
                saidadeaudiowave2.Pause();
                // Debug.WriteLine(String.Format("Paused to buffer, waveOut.PlaybackState={0}", waveOut.PlaybackState));
            }
        }

        private void Play()
        {
            if (streamdois == false)
            {
                saidadeaudiowave1.Play();
                // Debug.WriteLine(String.Format("Started playing, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                estadodoplay1 = StreamingPlaybackState.Playing;
            }
            if (streamdois == true)
            {
                saidadeaudiowave2.Play();
                // Debug.WriteLine(String.Format("Started playing, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                estadodoplay2 = StreamingPlaybackState.Playing;
            }
        }

        private void StopPlayback()
        {
            if (streamdois == false)
            {
                if (estadodoplay1 != StreamingPlaybackState.Stopped)
                {
                    if (!fullyDownloaded1)
                    {
                        requisicaodaweb1.Abort();
                    }

                    estadodoplay1 = StreamingPlaybackState.Stopped;
                    if (saidadeaudiowave1 != null)
                    {
                        saidadeaudiowave1.Stop();
                        saidadeaudiowave1.Dispose();
                        saidadeaudiowave1 = null;
                    }
                    tgA1.Enabled = false;
                    // n.b. streaming thread may not yet have exited
                    System.Threading.Thread.Sleep(500);
                    ShowBufferState(0);
                }
            }
            if (streamdois == true)
            {
                if (estadodoplay2 != StreamingPlaybackState.Stopped)
                {
                    if (!fullyDownloaded2)
                    {
                        requisicaodaweb2.Abort();
                    }

                    estadodoplay2 = StreamingPlaybackState.Stopped;
                    if (saidadeaudiowave2 != null)
                    {
                        saidadeaudiowave2.Stop();
                        saidadeaudiowave2.Dispose();
                        saidadeaudiowave2 = null;
                    }
                    tgA2.Enabled = false;
                    // n.b. streaming thread may not yet have exited
                    System.Threading.Thread.Sleep(500);
                    ShowBufferState(0);
                }
            }
        }

        private void ShowBufferState(double totalSeconds)
        {
            if (streamdois == false)
            {
                lblNibuf1.Text = String.Format("{0:0.0}s", totalSeconds);
                pbBuf1.Value = (int)(totalSeconds * 1000);
            }
            if (streamdois == true)
            {
                lblNibuf2.Text = String.Format("{0:0.0}s", totalSeconds);
                pbBuf2.Value = (int)(totalSeconds * 1000);
            }
        }

        private void ListaDispositivos()
        {
            regVol1.VolumeChanged += MudDoEstVol1;
            regVol2.VolumeChanged += MudDoEstVol2;
            Disposed += MP3StreamingPanel_Disposing;

            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                lstDispos.Items.Add($"{n}: {caps.ProductName}");
            }
        }

        void MudDoEstVol1(object sender, EventArgs e)
        {
            if (provedordevolumedeaudio1 != null)
            {
                provedordevolumedeaudio1.Volume = regVol1.Volume;
            }
        }

        void MudDoEstVol2(object sender, EventArgs e)
        {
            if (provedordevolumedeaudio2 != null)
            {
                provedordevolumedeaudio2.Volume = regVol2.Volume;
            }
        }

        private void MP3StreamingPanel_Disposing(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void TgA2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (estadodoplay2 != StreamingPlaybackState.Stopped)
                {
                    if (saidadeaudiowave2 == null && provedordebuffer2 != null)
                    {
                        int dispositivoid = lstDispos.SelectedIndex;
                        // Debug.WriteLine("Creating WaveOut Device");
                        saidadeaudiowave2 = CreateWaveOut();
                        saidadeaudiowave2.PlaybackStopped += OnPlaybackStopped;
                        provedordevolumedeaudio2 = new VolumeWaveProvider16(provedordebuffer2);
                        provedordevolumedeaudio2.Volume = new VolumeSlider().Volume;
                        provedordevolumedeaudio2.Volume = regVol2.Volume;
                        if (dispositivoid != -1)
                            dispositivoid = dispositivoid - 1;
                        saidadeaudiowave2 = new WaveOutEvent() { DeviceNumber = dispositivoid };
                        saidadeaudiowave2.Init(provedordevolumedeaudio2);
                        pbBuf2.Maximum = (int)provedordebuffer2.BufferDuration.TotalMilliseconds;
                    }
                    else if (provedordebuffer2 != null)
                    {
                        var bufferedSeconds = provedordebuffer2.BufferedDuration.TotalSeconds;
                        streamdois = true;
                        ShowBufferState(bufferedSeconds);
                        // make it stutter less if we buffer up a decent amount before playing
                        if (bufferedSeconds < 0.5 && estadodoplay2 == StreamingPlaybackState.Playing && !fullyDownloaded2)
                        {
                            // Pause();
                            StopPlayback();
                            System.Threading.Thread.Sleep(5000);
                            Audio2();
                        }
                        else if (bufferedSeconds > 4 && estadodoplay2 == StreamingPlaybackState.Buffering)
                        {
                            Play();
                        }
                        else if (fullyDownloaded2 && bufferedSeconds == 0)
                        {
                            // Debug.WriteLine("Reached end of stream");
                            StopPlayback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message + ex.StackTrace);
            }
        }

        private void ValidacoesGerais()
        {
            if (lstDispos.SelectedIndex == 0)
            {

            }
        }

        private void Temporizacao_Tick(object Sender, EventArgs e)
        {
            try
            {
                string informacaolink1 = txtUrltxt1.Text;
                string informacaolink2 = txtUrltxt2.Text;
                string informacaolink21 = txtUrltxt21.Text;
                string informacaolink22 = txtUrltxt22.Text;

                if (chkUsohorario.Checked == true)
                {
                    DateTime date = DateTime.Now;
                    DateTime hora1sinal1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txtHora1.Text), int.Parse(txtMinuto1.Text), 0);
                    DateTime hora2sinal1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txtHora2.Text), int.Parse(txtMinuto2.Text), 0);

                    int chaveamentoumdoisc1 = DateTime.Compare(date, hora1sinal1);
                    int chaveamentoumdoisc2 = DateTime.Compare(date, hora2sinal1);

                    if (chaveamentoumdoisc1 == 1 && chaveamentoumdoisc2 == -1)
                    {
                        regVol1.Volume = 1;
                        regVol2.Volume = 0;
                    }
                    else
                    {
                        regVol1.Volume = 0;
                        regVol2.Volume = 1;
                    }
                }
                if (chkUsohorario.Checked == false)
                {
                    if (txtString1.Text == informacaolink1 && txtString2.Text == informacaolink2)
                    {
                        regVol1.Volume = 1;
                        regVol2.Volume = 0;
                    }
                    if (txtString21.Text == informacaolink21 && txtString22.Text == informacaolink22)
                    {
                        regVol1.Volume = 0;
                        regVol2.Volume = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            streamdois = true;
            regVol1.Volume = 0;
            regVol2.Volume = 1;
        }

        private void BtnIniciachav_Click(object sender, EventArgs e)
        {
            try
            {
                btnIniciachav.Enabled = false;
                btnPararchav.Enabled = true;

                // Habilita execução
                temporizadorgeral.Enabled = true;

                // Define um intervalo para o bloco de códigos executar novamente definido para 5000 milisegundos
                temporizadorgeral.Interval = 1000;

                // Evento que ocorre a cada 5000 milisegundos para atualizar o texto do servidor
                temporizadorgeral.Tick += new EventHandler(Temporizacao_Tick);

                // Inicia o relógio
                temporizadorgeral.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPararchav_Click(object sender, EventArgs e)
        {
            try
            {
                btnIniciachav.Enabled = true;
                btnPararchav.Enabled = false;
                temporizadorgeral.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}