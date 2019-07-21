namespace StreamingSwitch
{
    partial class StreamingSwitch
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamingSwitch));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTextodisp = new System.Windows.Forms.Label();
            this.lstDispos = new System.Windows.Forms.ListBox();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.lblTextourl1 = new System.Windows.Forms.Label();
            this.lblTextourl2 = new System.Windows.Forms.Label();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.lblTextobuf1 = new System.Windows.Forms.Label();
            this.lblTextobuf2 = new System.Windows.Forms.Label();
            this.txtBuffer1 = new System.Windows.Forms.TextBox();
            this.txtBuffer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBuf1 = new System.Windows.Forms.ProgressBar();
            this.pbBuf2 = new System.Windows.Forms.ProgressBar();
            this.lblNibuf1 = new System.Windows.Forms.Label();
            this.lblNibuf2 = new System.Windows.Forms.Label();
            this.btnAudio1 = new System.Windows.Forms.Button();
            this.btnAudioparar1 = new System.Windows.Forms.Button();
            this.btnPararcomplet1 = new System.Windows.Forms.Button();
            this.btnPararcomplet2 = new System.Windows.Forms.Button();
            this.btnAudioparar2 = new System.Windows.Forms.Button();
            this.btnAudio2 = new System.Windows.Forms.Button();
            this.tgA1 = new System.Windows.Forms.Timer(this.components);
            this.regVol1 = new NAudio.Gui.VolumeSlider();
            this.lblTextovolc1 = new System.Windows.Forms.Label();
            this.lblTextovolc2 = new System.Windows.Forms.Label();
            this.regVol2 = new NAudio.Gui.VolumeSlider();
            this.tgA2 = new System.Windows.Forms.Timer(this.components);
            this.lblTextoch = new System.Windows.Forms.Label();
            this.txtHora1 = new System.Windows.Forms.TextBox();
            this.txtMinuto1 = new System.Windows.Forms.TextBox();
            this.txtMinuto2 = new System.Windows.Forms.TextBox();
            this.txtHora2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIniciachav = new System.Windows.Forms.Button();
            this.btnPararchav = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUsohorario = new System.Windows.Forms.CheckBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblTextodesctexto = new System.Windows.Forms.Label();
            this.lblTextoexplic = new System.Windows.Forms.Label();
            this.txtString22 = new System.Windows.Forms.TextBox();
            this.txtString21 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrltxt2 = new System.Windows.Forms.TextBox();
            this.txtUrltxt1 = new System.Windows.Forms.TextBox();
            this.txtUrltxt22 = new System.Windows.Forms.TextBox();
            this.txtUrltxt21 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(344, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Streaming Audio Switch By GabardoHost";
            // 
            // lblTextodisp
            // 
            this.lblTextodisp.AutoSize = true;
            this.lblTextodisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextodisp.Location = new System.Drawing.Point(12, 305);
            this.lblTextodisp.Name = "lblTextodisp";
            this.lblTextodisp.Size = new System.Drawing.Size(368, 16);
            this.lblTextodisp.TabIndex = 1;
            this.lblTextodisp.Text = "Selecione o dispositivo de áudio para saída dos dois sinais:";
            // 
            // lstDispos
            // 
            this.lstDispos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDispos.FormattingEnabled = true;
            this.lstDispos.ItemHeight = 16;
            this.lstDispos.Location = new System.Drawing.Point(12, 322);
            this.lstDispos.Name = "lstDispos";
            this.lstDispos.Size = new System.Drawing.Size(472, 116);
            this.lstDispos.TabIndex = 2;
            // 
            // txtUrl1
            // 
            this.txtUrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl1.Location = new System.Drawing.Point(12, 62);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(472, 22);
            this.txtUrl1.TabIndex = 3;
            // 
            // lblTextourl1
            // 
            this.lblTextourl1.AutoSize = true;
            this.lblTextourl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextourl1.Location = new System.Drawing.Point(201, 43);
            this.lblTextourl1.Name = "lblTextourl1";
            this.lblTextourl1.Size = new System.Drawing.Size(98, 16);
            this.lblTextourl1.TabIndex = 4;
            this.lblTextourl1.Text = "URL do sinal 1:";
            // 
            // lblTextourl2
            // 
            this.lblTextourl2.AutoSize = true;
            this.lblTextourl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextourl2.Location = new System.Drawing.Point(703, 43);
            this.lblTextourl2.Name = "lblTextourl2";
            this.lblTextourl2.Size = new System.Drawing.Size(98, 16);
            this.lblTextourl2.TabIndex = 5;
            this.lblTextourl2.Text = "URL do sinal 2:";
            // 
            // txtUrl2
            // 
            this.txtUrl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl2.Location = new System.Drawing.Point(510, 62);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(445, 22);
            this.txtUrl2.TabIndex = 6;
            // 
            // lblTextobuf1
            // 
            this.lblTextobuf1.AutoSize = true;
            this.lblTextobuf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextobuf1.Location = new System.Drawing.Point(159, 89);
            this.lblTextobuf1.Name = "lblTextobuf1";
            this.lblTextobuf1.Size = new System.Drawing.Size(170, 16);
            this.lblTextobuf1.TabIndex = 7;
            this.lblTextobuf1.Text = "Tempo de buffer do sinal 1:";
            // 
            // lblTextobuf2
            // 
            this.lblTextobuf2.AutoSize = true;
            this.lblTextobuf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextobuf2.Location = new System.Drawing.Point(655, 89);
            this.lblTextobuf2.Name = "lblTextobuf2";
            this.lblTextobuf2.Size = new System.Drawing.Size(170, 16);
            this.lblTextobuf2.TabIndex = 8;
            this.lblTextobuf2.Text = "Tempo de buffer do sinal 2:";
            // 
            // txtBuffer1
            // 
            this.txtBuffer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffer1.Location = new System.Drawing.Point(179, 108);
            this.txtBuffer1.Name = "txtBuffer1";
            this.txtBuffer1.Size = new System.Drawing.Size(133, 22);
            this.txtBuffer1.TabIndex = 9;
            // 
            // txtBuffer2
            // 
            this.txtBuffer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffer2.Location = new System.Drawing.Point(668, 108);
            this.txtBuffer2.Name = "txtBuffer2";
            this.txtBuffer2.Size = new System.Drawing.Size(133, 22);
            this.txtBuffer2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tempo efetivo de buffer do sinal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tempo efetivo de buffer do sinal 2:";
            // 
            // pbBuf1
            // 
            this.pbBuf1.Location = new System.Drawing.Point(12, 166);
            this.pbBuf1.Name = "pbBuf1";
            this.pbBuf1.Size = new System.Drawing.Size(427, 23);
            this.pbBuf1.TabIndex = 13;
            // 
            // pbBuf2
            // 
            this.pbBuf2.Location = new System.Drawing.Point(510, 166);
            this.pbBuf2.Name = "pbBuf2";
            this.pbBuf2.Size = new System.Drawing.Size(445, 23);
            this.pbBuf2.TabIndex = 14;
            // 
            // lblNibuf1
            // 
            this.lblNibuf1.AutoSize = true;
            this.lblNibuf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNibuf1.Location = new System.Drawing.Point(445, 170);
            this.lblNibuf1.Name = "lblNibuf1";
            this.lblNibuf1.Size = new System.Drawing.Size(22, 16);
            this.lblNibuf1.TabIndex = 15;
            this.lblNibuf1.Text = "0s";
            // 
            // lblNibuf2
            // 
            this.lblNibuf2.AutoSize = true;
            this.lblNibuf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNibuf2.Location = new System.Drawing.Point(959, 170);
            this.lblNibuf2.Name = "lblNibuf2";
            this.lblNibuf2.Size = new System.Drawing.Size(22, 16);
            this.lblNibuf2.TabIndex = 16;
            this.lblNibuf2.Text = "0s";
            // 
            // btnAudio1
            // 
            this.btnAudio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio1.Location = new System.Drawing.Point(13, 196);
            this.btnAudio1.Name = "btnAudio1";
            this.btnAudio1.Size = new System.Drawing.Size(173, 36);
            this.btnAudio1.TabIndex = 17;
            this.btnAudio1.Text = "Carregar Áudio do Link 1";
            this.btnAudio1.UseVisualStyleBackColor = true;
            this.btnAudio1.Click += new System.EventHandler(this.BtnAudio1_Click);
            // 
            // btnAudioparar1
            // 
            this.btnAudioparar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudioparar1.Location = new System.Drawing.Point(192, 196);
            this.btnAudioparar1.Name = "btnAudioparar1";
            this.btnAudioparar1.Size = new System.Drawing.Size(150, 36);
            this.btnAudioparar1.TabIndex = 18;
            this.btnAudioparar1.Text = "Parar e carregar buffer";
            this.btnAudioparar1.UseVisualStyleBackColor = true;
            this.btnAudioparar1.Click += new System.EventHandler(this.BtnAudioparar1_Click);
            // 
            // btnPararcomplet1
            // 
            this.btnPararcomplet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararcomplet1.Location = new System.Drawing.Point(348, 196);
            this.btnPararcomplet1.Name = "btnPararcomplet1";
            this.btnPararcomplet1.Size = new System.Drawing.Size(136, 36);
            this.btnPararcomplet1.TabIndex = 19;
            this.btnPararcomplet1.Text = "Parar e limpar buffer";
            this.btnPararcomplet1.UseVisualStyleBackColor = true;
            this.btnPararcomplet1.Click += new System.EventHandler(this.BtnPararcomplet1_Click);
            // 
            // btnPararcomplet2
            // 
            this.btnPararcomplet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararcomplet2.Location = new System.Drawing.Point(844, 196);
            this.btnPararcomplet2.Name = "btnPararcomplet2";
            this.btnPararcomplet2.Size = new System.Drawing.Size(136, 36);
            this.btnPararcomplet2.TabIndex = 22;
            this.btnPararcomplet2.Text = "Parar e limpar buffer";
            this.btnPararcomplet2.UseVisualStyleBackColor = true;
            this.btnPararcomplet2.Click += new System.EventHandler(this.BtnPararcomplet2_Click);
            // 
            // btnAudioparar2
            // 
            this.btnAudioparar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudioparar2.Location = new System.Drawing.Point(681, 196);
            this.btnAudioparar2.Name = "btnAudioparar2";
            this.btnAudioparar2.Size = new System.Drawing.Size(157, 36);
            this.btnAudioparar2.TabIndex = 21;
            this.btnAudioparar2.Text = "Parar e carregar buffer";
            this.btnAudioparar2.UseVisualStyleBackColor = true;
            this.btnAudioparar2.Click += new System.EventHandler(this.BtnAudioparar2_Click);
            // 
            // btnAudio2
            // 
            this.btnAudio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio2.Location = new System.Drawing.Point(510, 196);
            this.btnAudio2.Name = "btnAudio2";
            this.btnAudio2.Size = new System.Drawing.Size(165, 36);
            this.btnAudio2.TabIndex = 20;
            this.btnAudio2.Text = "Carregar Áudio do Link 2";
            this.btnAudio2.UseVisualStyleBackColor = true;
            this.btnAudio2.Click += new System.EventHandler(this.BtnAudio2_Click);
            // 
            // tgA1
            // 
            this.tgA1.Tick += new System.EventHandler(this.TgA1_Tick);
            // 
            // regVol1
            // 
            this.regVol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regVol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regVol1.Location = new System.Drawing.Point(13, 260);
            this.regVol1.Name = "regVol1";
            this.regVol1.Size = new System.Drawing.Size(471, 29);
            this.regVol1.TabIndex = 23;
            // 
            // lblTextovolc1
            // 
            this.lblTextovolc1.AutoSize = true;
            this.lblTextovolc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextovolc1.Location = new System.Drawing.Point(13, 235);
            this.lblTextovolc1.Name = "lblTextovolc1";
            this.lblTextovolc1.Size = new System.Drawing.Size(173, 16);
            this.lblTextovolc1.TabIndex = 24;
            this.lblTextovolc1.Text = "Volume do áudio do sinal 1:";
            // 
            // lblTextovolc2
            // 
            this.lblTextovolc2.AutoSize = true;
            this.lblTextovolc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextovolc2.Location = new System.Drawing.Point(671, 235);
            this.lblTextovolc2.Name = "lblTextovolc2";
            this.lblTextovolc2.Size = new System.Drawing.Size(173, 16);
            this.lblTextovolc2.TabIndex = 25;
            this.lblTextovolc2.Text = "Volume do áudio do sinal 2:";
            // 
            // regVol2
            // 
            this.regVol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regVol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regVol2.Location = new System.Drawing.Point(510, 260);
            this.regVol2.Name = "regVol2";
            this.regVol2.Size = new System.Drawing.Size(471, 29);
            this.regVol2.TabIndex = 26;
            this.regVol2.Volume = 0F;
            // 
            // tgA2
            // 
            this.tgA2.Tick += new System.EventHandler(this.TgA2_Tick);
            // 
            // lblTextoch
            // 
            this.lblTextoch.AutoSize = true;
            this.lblTextoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoch.Location = new System.Drawing.Point(615, 305);
            this.lblTextoch.Name = "lblTextoch";
            this.lblTextoch.Size = new System.Drawing.Size(51, 16);
            this.lblTextoch.TabIndex = 27;
            this.lblTextoch.Text = "Sinal 1:";
            // 
            // txtHora1
            // 
            this.txtHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora1.Location = new System.Drawing.Point(618, 322);
            this.txtHora1.Name = "txtHora1";
            this.txtHora1.Size = new System.Drawing.Size(63, 22);
            this.txtHora1.TabIndex = 30;
            // 
            // txtMinuto1
            // 
            this.txtMinuto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuto1.Location = new System.Drawing.Point(706, 322);
            this.txtMinuto1.Name = "txtMinuto1";
            this.txtMinuto1.Size = new System.Drawing.Size(63, 22);
            this.txtMinuto1.TabIndex = 32;
            // 
            // txtMinuto2
            // 
            this.txtMinuto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuto2.Location = new System.Drawing.Point(892, 322);
            this.txtMinuto2.Name = "txtMinuto2";
            this.txtMinuto2.Size = new System.Drawing.Size(63, 22);
            this.txtMinuto2.TabIndex = 35;
            // 
            // txtHora2
            // 
            this.txtHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora2.Location = new System.Drawing.Point(804, 322);
            this.txtHora2.Name = "txtHora2";
            this.txtHora2.Size = new System.Drawing.Size(63, 22);
            this.txtHora2.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "De:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Até:";
            // 
            // btnIniciachav
            // 
            this.btnIniciachav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciachav.Location = new System.Drawing.Point(618, 376);
            this.btnIniciachav.Name = "btnIniciachav";
            this.btnIniciachav.Size = new System.Drawing.Size(151, 23);
            this.btnIniciachav.TabIndex = 42;
            this.btnIniciachav.Text = "Iniciar Chaveamento";
            this.btnIniciachav.UseVisualStyleBackColor = true;
            this.btnIniciachav.Click += new System.EventHandler(this.BtnIniciachav_Click);
            // 
            // btnPararchav
            // 
            this.btnPararchav.Enabled = false;
            this.btnPararchav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararchav.Location = new System.Drawing.Point(804, 376);
            this.btnPararchav.Name = "btnPararchav";
            this.btnPararchav.Size = new System.Drawing.Size(151, 23);
            this.btnPararchav.TabIndex = 43;
            this.btnPararchav.Text = "Parar Chaveamento";
            this.btnPararchav.UseVisualStyleBackColor = true;
            this.btnPararchav.Click += new System.EventHandler(this.BtnPararchav_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Apos e antes desse horário definido, o sinal fica ativo a URL 2";
            // 
            // chkUsohorario
            // 
            this.chkUsohorario.AutoSize = true;
            this.chkUsohorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsohorario.Location = new System.Drawing.Point(618, 405);
            this.chkUsohorario.Name = "chkUsohorario";
            this.chkUsohorario.Size = new System.Drawing.Size(227, 20);
            this.chkUsohorario.TabIndex = 45;
            this.chkUsohorario.Text = "Chavear áudio através de horário";
            this.chkUsohorario.UseVisualStyleBackColor = true;
            // 
            // txtString1
            // 
            this.txtString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString1.Location = new System.Drawing.Point(12, 473);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(182, 22);
            this.txtString1.TabIndex = 46;
            // 
            // txtString2
            // 
            this.txtString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString2.Location = new System.Drawing.Point(12, 514);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(182, 22);
            this.txtString2.TabIndex = 47;
            // 
            // lblTextodesctexto
            // 
            this.lblTextodesctexto.AutoSize = true;
            this.lblTextodesctexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextodesctexto.Location = new System.Drawing.Point(9, 442);
            this.lblTextodesctexto.Name = "lblTextodesctexto";
            this.lblTextodesctexto.Size = new System.Drawing.Size(490, 16);
            this.lblTextodesctexto.TabIndex = 51;
            this.lblTextodesctexto.Text = "Caso encontre no arquivo texto lido os seguintes textos mudar para URL e Sinal 1";
            // 
            // lblTextoexplic
            // 
            this.lblTextoexplic.AutoSize = true;
            this.lblTextoexplic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoexplic.Location = new System.Drawing.Point(10, 540);
            this.lblTextoexplic.Name = "lblTextoexplic";
            this.lblTextoexplic.Size = new System.Drawing.Size(289, 16);
            this.lblTextoexplic.TabIndex = 52;
            this.lblTextoexplic.Text = "OBS: Textos não preenchidos serão ignorados";
            // 
            // txtString22
            // 
            this.txtString22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString22.Location = new System.Drawing.Point(777, 514);
            this.txtString22.Name = "txtString22";
            this.txtString22.Size = new System.Drawing.Size(178, 22);
            this.txtString22.TabIndex = 54;
            // 
            // txtString21
            // 
            this.txtString21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString21.Location = new System.Drawing.Point(777, 473);
            this.txtString21.Name = "txtString21";
            this.txtString21.Size = new System.Drawing.Size(178, 22);
            this.txtString21.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(490, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Caso encontre no arquivo texto lido os seguintes textos mudar para URL e Sinal 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "OBS: Textos não preenchidos serão ignorados";
            // 
            // txtUrltxt2
            // 
            this.txtUrltxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrltxt2.Location = new System.Drawing.Point(236, 514);
            this.txtUrltxt2.Name = "txtUrltxt2";
            this.txtUrltxt2.Size = new System.Drawing.Size(182, 22);
            this.txtUrltxt2.TabIndex = 61;
            // 
            // txtUrltxt1
            // 
            this.txtUrltxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrltxt1.Location = new System.Drawing.Point(236, 473);
            this.txtUrltxt1.Name = "txtUrltxt1";
            this.txtUrltxt1.Size = new System.Drawing.Size(182, 22);
            this.txtUrltxt1.TabIndex = 60;
            // 
            // txtUrltxt22
            // 
            this.txtUrltxt22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrltxt22.Location = new System.Drawing.Point(527, 514);
            this.txtUrltxt22.Name = "txtUrltxt22";
            this.txtUrltxt22.Size = new System.Drawing.Size(178, 22);
            this.txtUrltxt22.TabIndex = 66;
            // 
            // txtUrltxt21
            // 
            this.txtUrltxt21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrltxt21.Location = new System.Drawing.Point(527, 473);
            this.txtUrltxt21.Name = "txtUrltxt21";
            this.txtUrltxt21.Size = new System.Drawing.Size(178, 22);
            this.txtUrltxt21.TabIndex = 65;
            // 
            // StreamingSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 562);
            this.Controls.Add(this.txtUrltxt22);
            this.Controls.Add(this.txtUrltxt21);
            this.Controls.Add(this.txtUrltxt2);
            this.Controls.Add(this.txtUrltxt1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtString22);
            this.Controls.Add(this.txtString21);
            this.Controls.Add(this.lblTextoexplic);
            this.Controls.Add(this.lblTextodesctexto);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.chkUsohorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPararchav);
            this.Controls.Add(this.btnIniciachav);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinuto2);
            this.Controls.Add(this.txtHora2);
            this.Controls.Add(this.txtMinuto1);
            this.Controls.Add(this.txtHora1);
            this.Controls.Add(this.lblTextoch);
            this.Controls.Add(this.regVol2);
            this.Controls.Add(this.lblTextovolc2);
            this.Controls.Add(this.lblTextovolc1);
            this.Controls.Add(this.regVol1);
            this.Controls.Add(this.btnPararcomplet2);
            this.Controls.Add(this.btnAudioparar2);
            this.Controls.Add(this.btnAudio2);
            this.Controls.Add(this.btnPararcomplet1);
            this.Controls.Add(this.btnAudioparar1);
            this.Controls.Add(this.btnAudio1);
            this.Controls.Add(this.lblNibuf2);
            this.Controls.Add(this.lblNibuf1);
            this.Controls.Add(this.pbBuf2);
            this.Controls.Add(this.pbBuf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuffer2);
            this.Controls.Add(this.txtBuffer1);
            this.Controls.Add(this.lblTextobuf2);
            this.Controls.Add(this.lblTextobuf1);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.lblTextourl2);
            this.Controls.Add(this.lblTextourl1);
            this.Controls.Add(this.txtUrl1);
            this.Controls.Add(this.lstDispos);
            this.Controls.Add(this.lblTextodisp);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StreamingSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streaming Switch By GabardoHost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTextodisp;
        private System.Windows.Forms.ListBox lstDispos;
        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.Label lblTextourl1;
        private System.Windows.Forms.Label lblTextourl2;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Label lblTextobuf1;
        private System.Windows.Forms.Label lblTextobuf2;
        private System.Windows.Forms.TextBox txtBuffer1;
        private System.Windows.Forms.TextBox txtBuffer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbBuf1;
        private System.Windows.Forms.ProgressBar pbBuf2;
        private System.Windows.Forms.Label lblNibuf1;
        private System.Windows.Forms.Label lblNibuf2;
        private System.Windows.Forms.Button btnAudio1;
        private System.Windows.Forms.Button btnAudioparar1;
        private System.Windows.Forms.Button btnPararcomplet1;
        private System.Windows.Forms.Button btnPararcomplet2;
        private System.Windows.Forms.Button btnAudioparar2;
        private System.Windows.Forms.Button btnAudio2;
        private System.Windows.Forms.Timer tgA1;
        private NAudio.Gui.VolumeSlider regVol1;
        private System.Windows.Forms.Label lblTextovolc1;
        private System.Windows.Forms.Label lblTextovolc2;
        private NAudio.Gui.VolumeSlider regVol2;
        private System.Windows.Forms.Timer tgA2;
        private System.Windows.Forms.Label lblTextoch;
        private System.Windows.Forms.TextBox txtHora1;
        private System.Windows.Forms.TextBox txtMinuto1;
        private System.Windows.Forms.TextBox txtMinuto2;
        private System.Windows.Forms.TextBox txtHora2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIniciachav;
        private System.Windows.Forms.Button btnPararchav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUsohorario;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblTextodesctexto;
        private System.Windows.Forms.Label lblTextoexplic;
        private System.Windows.Forms.TextBox txtString22;
        private System.Windows.Forms.TextBox txtString21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrltxt2;
        private System.Windows.Forms.TextBox txtUrltxt1;
        private System.Windows.Forms.TextBox txtUrltxt22;
        private System.Windows.Forms.TextBox txtUrltxt21;
    }
}

