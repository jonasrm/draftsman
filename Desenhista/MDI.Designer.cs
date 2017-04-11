namespace Desenhista
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picOrigem = new System.Windows.Forms.PictureBox();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.btnSelecionarOrigem = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtMutacao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGeracoes = new System.Windows.Forms.NumericUpDown();
            this.txtPopulacao = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGeracao = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnTodasEtapas = new System.Windows.Forms.Button();
            this.btnProximaEtapa = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.picThreshold = new System.Windows.Forms.PictureBox();
            this.picBestThreshold = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDNA = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAvaliacao = new System.Windows.Forms.ComboBox();
            this.cmbSelecao = new System.Windows.Forms.ComboBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopulacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBestThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrigem
            // 
            this.picOrigem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picOrigem.Location = new System.Drawing.Point(12, 143);
            this.picOrigem.Name = "picOrigem";
            this.picOrigem.Size = new System.Drawing.Size(200, 200);
            this.picOrigem.TabIndex = 2;
            this.picOrigem.TabStop = false;
            // 
            // picResultado
            // 
            this.picResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picResultado.Location = new System.Drawing.Point(336, 143);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(200, 200);
            this.picResultado.TabIndex = 3;
            this.picResultado.TabStop = false;
            // 
            // btnSelecionarOrigem
            // 
            this.btnSelecionarOrigem.Location = new System.Drawing.Point(12, 96);
            this.btnSelecionarOrigem.Name = "btnSelecionarOrigem";
            this.btnSelecionarOrigem.Size = new System.Drawing.Size(524, 24);
            this.btnSelecionarOrigem.TabIndex = 4;
            this.btnSelecionarOrigem.Text = "Selecionar Imagem...";
            this.btnSelecionarOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionarOrigem.Click += new System.EventHandler(this.btnSelecionarOrigem_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(336, 8);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(141, 75);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtMutacao
            // 
            this.txtMutacao.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtMutacao.Location = new System.Drawing.Point(83, 64);
            this.txtMutacao.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.txtMutacao.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtMutacao.Name = "txtMutacao";
            this.txtMutacao.Size = new System.Drawing.Size(61, 20);
            this.txtMutacao.TabIndex = 25;
            this.txtMutacao.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mutação %:";
            // 
            // txtGeracoes
            // 
            this.txtGeracoes.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGeracoes.Location = new System.Drawing.Point(83, 38);
            this.txtGeracoes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtGeracoes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGeracoes.Name = "txtGeracoes";
            this.txtGeracoes.Size = new System.Drawing.Size(61, 20);
            this.txtGeracoes.TabIndex = 23;
            this.txtGeracoes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPopulacao.Location = new System.Drawing.Point(83, 12);
            this.txtPopulacao.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(61, 20);
            this.txtPopulacao.TabIndex = 22;
            this.txtPopulacao.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gerações:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "População:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Geração:";
            // 
            // lblGeracao
            // 
            this.lblGeracao.AutoSize = true;
            this.lblGeracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeracao.Location = new System.Drawing.Point(209, 508);
            this.lblGeracao.Name = "lblGeracao";
            this.lblGeracao.Size = new System.Drawing.Size(21, 24);
            this.lblGeracao.TabIndex = 29;
            this.lblGeracao.Text = "0";
            this.lblGeracao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(36, 512);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(41, 13);
            this.lblEtapa.TabIndex = 28;
            this.lblEtapa.Text = "Parado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Log:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 476);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(524, 23);
            this.progressBar.TabIndex = 26;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(483, 58);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(53, 25);
            this.btnParar.TabIndex = 33;
            this.btnParar.Text = "[  ]";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnTodasEtapas
            // 
            this.btnTodasEtapas.Location = new System.Drawing.Point(483, 33);
            this.btnTodasEtapas.Name = "btnTodasEtapas";
            this.btnTodasEtapas.Size = new System.Drawing.Size(53, 25);
            this.btnTodasEtapas.TabIndex = 32;
            this.btnTodasEtapas.Text = ">>";
            this.btnTodasEtapas.UseVisualStyleBackColor = true;
            this.btnTodasEtapas.Click += new System.EventHandler(this.btnTodasEtapas_Click);
            // 
            // btnProximaEtapa
            // 
            this.btnProximaEtapa.Location = new System.Drawing.Point(483, 8);
            this.btnProximaEtapa.Name = "btnProximaEtapa";
            this.btnProximaEtapa.Size = new System.Drawing.Size(53, 25);
            this.btnProximaEtapa.TabIndex = 31;
            this.btnProximaEtapa.Text = ">";
            this.btnProximaEtapa.UseVisualStyleBackColor = true;
            this.btnProximaEtapa.Click += new System.EventHandler(this.btnProximaEtapa_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.p1.Location = new System.Drawing.Point(12, 349);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 100);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 34;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.p2.Location = new System.Drawing.Point(118, 349);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 100);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 35;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.p3.Location = new System.Drawing.Point(224, 349);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 100);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 36;
            this.p3.TabStop = false;
            // 
            // picThreshold
            // 
            this.picThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picThreshold.Location = new System.Drawing.Point(218, 143);
            this.picThreshold.Name = "picThreshold";
            this.picThreshold.Size = new System.Drawing.Size(90, 90);
            this.picThreshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThreshold.TabIndex = 44;
            this.picThreshold.TabStop = false;
            // 
            // picBestThreshold
            // 
            this.picBestThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBestThreshold.Location = new System.Drawing.Point(240, 253);
            this.picBestThreshold.Name = "picBestThreshold";
            this.picBestThreshold.Size = new System.Drawing.Size(90, 90);
            this.picBestThreshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBestThreshold.TabIndex = 45;
            this.picBestThreshold.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Fitness:";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFitness.Location = new System.Drawing.Point(353, 508);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(21, 24);
            this.lblFitness.TabIndex = 51;
            this.lblFitness.Text = "0";
            this.lblFitness.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "DNA:";
            // 
            // lblDNA
            // 
            this.lblDNA.AutoSize = true;
            this.lblDNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNA.Location = new System.Drawing.Point(470, 508);
            this.lblDNA.Name = "lblDNA";
            this.lblDNA.Size = new System.Drawing.Size(21, 24);
            this.lblDNA.TabIndex = 53;
            this.lblDNA.Text = "0";
            this.lblDNA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.p4.Location = new System.Drawing.Point(330, 349);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(100, 100);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 37;
            this.p4.TabStop = false;
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.p5.Location = new System.Drawing.Point(436, 349);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(100, 100);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 55;
            this.p5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Seleção:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Avaliação:";
            // 
            // cmbAvaliacao
            // 
            this.cmbAvaliacao.FormattingEnabled = true;
            this.cmbAvaliacao.Location = new System.Drawing.Point(210, 11);
            this.cmbAvaliacao.Name = "cmbAvaliacao";
            this.cmbAvaliacao.Size = new System.Drawing.Size(105, 21);
            this.cmbAvaliacao.TabIndex = 58;
            // 
            // cmbSelecao
            // 
            this.cmbSelecao.FormattingEnabled = true;
            this.cmbSelecao.Location = new System.Drawing.Point(210, 37);
            this.cmbSelecao.Name = "cmbSelecao";
            this.cmbSelecao.Size = new System.Drawing.Size(105, 21);
            this.cmbSelecao.TabIndex = 59;
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Location = new System.Drawing.Point(210, 63);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(105, 21);
            this.cmbForma.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Forma:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Objetivo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Melhor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "2º";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "3º";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(221, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "4º";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(406, 452);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "N-1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(523, 452);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "N";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 540);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSelecao);
            this.Controls.Add(this.cmbAvaliacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDNA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.picBestThreshold);
            this.Controls.Add(this.picThreshold);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnTodasEtapas);
            this.Controls.Add(this.btnProximaEtapa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGeracao);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtMutacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGeracoes);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSelecionarOrigem);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.picOrigem);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenhista";
            this.Load += new System.EventHandler(this.MDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopulacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBestThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrigem;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Button btnSelecionarOrigem;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown txtMutacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtGeracoes;
        private System.Windows.Forms.NumericUpDown txtPopulacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGeracao;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTodasEtapas;
        private System.Windows.Forms.Button btnProximaEtapa;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox picThreshold;
        private System.Windows.Forms.PictureBox picBestThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDNA;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAvaliacao;
        private System.Windows.Forms.ComboBox cmbSelecao;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

