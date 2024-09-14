namespace progetto_chiosco
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCasa = new System.Windows.Forms.PictureBox();
            this.pictureOspite = new System.Windows.Forms.PictureBox();
            this.timerScreenSaver = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerControlloSensore = new System.Windows.Forms.Timer(this.components);
            this.timerFineLogin = new System.Windows.Forms.Timer(this.components);
            this.timerImgChange = new System.Windows.Forms.Timer(this.components);
            this.labelCasa = new System.Windows.Forms.Label();
            this.labelOspite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOspite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(13, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureCasa
            // 
            this.pictureCasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureCasa.Location = new System.Drawing.Point(30, 150);
            this.pictureCasa.Margin = new System.Windows.Forms.Padding(2);
            this.pictureCasa.Name = "pictureCasa";
            this.pictureCasa.Size = new System.Drawing.Size(285, 288);
            this.pictureCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCasa.TabIndex = 2;
            this.pictureCasa.TabStop = false;
            this.pictureCasa.Visible = false;
            this.pictureCasa.Click += new System.EventHandler(this.pictureCasa_Click);
            // 
            // pictureOspite
            // 
            this.pictureOspite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureOspite.Location = new System.Drawing.Point(490, 150);
            this.pictureOspite.Margin = new System.Windows.Forms.Padding(2);
            this.pictureOspite.Name = "pictureOspite";
            this.pictureOspite.Size = new System.Drawing.Size(285, 285);
            this.pictureOspite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOspite.TabIndex = 3;
            this.pictureOspite.TabStop = false;
            this.pictureOspite.Visible = false;
            this.pictureOspite.Click += new System.EventHandler(this.pictureOspite_Click);
            // 
            // timerScreenSaver
            // 
            this.timerScreenSaver.Interval = 20000;
            this.timerScreenSaver.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(811, 531);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDoubleClick);
            // 
            // timerControlloSensore
            // 
            this.timerControlloSensore.Tick += new System.EventHandler(this.timerControlloSensore_Tick);
            // 
            // timerFineLogin
            // 
            this.timerFineLogin.Interval = 5000;
            this.timerFineLogin.Tick += new System.EventHandler(this.timerFineLogin_Tick);
            // 
            // timerImgChange
            // 
            this.timerImgChange.Enabled = true;
            this.timerImgChange.Interval = 300000;
            this.timerImgChange.Tick += new System.EventHandler(this.timerImgChange_Tick);
            // 
            // labelCasa
            // 
            this.labelCasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCasa.AutoSize = true;
            this.labelCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCasa.Location = new System.Drawing.Point(41, 461);
            this.labelCasa.Name = "labelCasa";
            this.labelCasa.Size = new System.Drawing.Size(274, 46);
            this.labelCasa.TabIndex = 5;
            this.labelCasa.Text = "Collaboratore";
            this.labelCasa.Visible = false;
            // 
            // labelOspite
            // 
            this.labelOspite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOspite.AutoSize = true;
            this.labelOspite.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOspite.Location = new System.Drawing.Point(565, 461);
            this.labelOspite.Name = "labelOspite";
            this.labelOspite.Size = new System.Drawing.Size(141, 46);
            this.labelOspite.TabIndex = 6;
            this.labelOspite.Text = "Ospite";
            this.labelOspite.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 519);
            this.Controls.Add(this.labelOspite);
            this.Controls.Add(this.labelCasa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureOspite);
            this.Controls.Add(this.pictureCasa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOspite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureCasa;
        private System.Windows.Forms.PictureBox pictureOspite;
        private System.Windows.Forms.Timer timerScreenSaver;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerControlloSensore;
        private System.Windows.Forms.Timer timerFineLogin;
        private System.Windows.Forms.Timer timerImgChange;
        private System.Windows.Forms.Label labelCasa;
        private System.Windows.Forms.Label labelOspite;
    }
}

