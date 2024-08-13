namespace Youtube_Downloader
{
    partial class frDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDown));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.rdMp3 = new System.Windows.Forms.RadioButton();
            this.rdMp4 = new System.Windows.Forms.RadioButton();
            this.CmbQualidade = new System.Windows.Forms.ComboBox();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PicControle = new System.Windows.Forms.PictureBox();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.LBFicheiro = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicControle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(13, 10);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1025, 40);
            this.txtUrl.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.Blue;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.Location = new System.Drawing.Point(1045, 10);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(104, 42);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // rdMp3
            // 
            this.rdMp3.AutoSize = true;
            this.rdMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp3.Location = new System.Drawing.Point(13, 61);
            this.rdMp3.Name = "rdMp3";
            this.rdMp3.Size = new System.Drawing.Size(177, 33);
            this.rdMp3.TabIndex = 2;
            this.rdMp3.TabStop = true;
            this.rdMp3.Text = "Formato Mp3";
            this.rdMp3.UseVisualStyleBackColor = true;
            // 
            // rdMp4
            // 
            this.rdMp4.AutoSize = true;
            this.rdMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp4.Location = new System.Drawing.Point(267, 60);
            this.rdMp4.Name = "rdMp4";
            this.rdMp4.Size = new System.Drawing.Size(177, 33);
            this.rdMp4.TabIndex = 3;
            this.rdMp4.TabStop = true;
            this.rdMp4.Text = "Formato Mp4";
            this.rdMp4.UseVisualStyleBackColor = true;
            // 
            // CmbQualidade
            // 
            this.CmbQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbQualidade.FormattingEnabled = true;
            this.CmbQualidade.Location = new System.Drawing.Point(541, 60);
            this.CmbQualidade.Name = "CmbQualidade";
            this.CmbQualidade.Size = new System.Drawing.Size(249, 37);
            this.CmbQualidade.TabIndex = 4;
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.Color.Blue;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.ForeColor = System.Drawing.Color.White;
            this.BtnDownload.Location = new System.Drawing.Point(12, 111);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(153, 44);
            this.BtnDownload.TabIndex = 5;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Blue;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(181, 110);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(153, 44);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Blue;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(349, 108);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(153, 44);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PicControle
            // 
            this.PicControle.BackColor = System.Drawing.Color.White;
            this.PicControle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicControle.Location = new System.Drawing.Point(13, 163);
            this.PicControle.Name = "PicControle";
            this.PicControle.Size = new System.Drawing.Size(1142, 109);
            this.PicControle.TabIndex = 10;
            this.PicControle.TabStop = false;
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(32, 174);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(1104, 30);
            this.Avanco.TabIndex = 11;
            // 
            // LBFicheiro
            // 
            this.LBFicheiro.AutoSize = true;
            this.LBFicheiro.BackColor = System.Drawing.Color.White;
            this.LBFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFicheiro.Location = new System.Drawing.Point(37, 225);
            this.LBFicheiro.Name = "LBFicheiro";
            this.LBFicheiro.Size = new System.Drawing.Size(146, 29);
            this.LBFicheiro.TabIndex = 12;
            this.LBFicheiro.Text = "Download ...";
            // 
            // BtnPrev
            // 
            this.BtnPrev.BackColor = System.Drawing.Color.Blue;
            this.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrev.ForeColor = System.Drawing.Color.White;
            this.BtnPrev.Location = new System.Drawing.Point(799, 58);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(239, 46);
            this.BtnPrev.TabIndex = 13;
            this.BtnPrev.Text = "Previsualizar Na Web";
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnAutor
            // 
            this.BtnAutor.BackColor = System.Drawing.Color.Blue;
            this.BtnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutor.ForeColor = System.Drawing.Color.White;
            this.BtnAutor.Location = new System.Drawing.Point(1044, 60);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(104, 44);
            this.BtnAutor.TabIndex = 14;
            this.BtnAutor.Text = "Autor";
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // frDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1161, 279);
            this.Controls.Add(this.BtnAutor);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.LBFicheiro);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.PicControle);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.CmbQualidade);
            this.Controls.Add(this.rdMp4);
            this.Controls.Add(this.rdMp3);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube downloader © Dev Joel 2024 Portugal PT-PT versão 5";
            ((System.ComponentModel.ISupportInitialize)(this.PicControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.RadioButton rdMp3;
        private System.Windows.Forms.RadioButton rdMp4;
        private System.Windows.Forms.ComboBox CmbQualidade;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox PicControle;
        private System.Windows.Forms.ProgressBar Avanco;
        private System.Windows.Forms.Label LBFicheiro;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnAutor;
    }
}

