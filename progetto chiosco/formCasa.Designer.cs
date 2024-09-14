namespace progetto_chiosco
{
    partial class formCasa
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxDipendenti = new System.Windows.Forms.ComboBox();
            this.labelCollaboratore = new System.Windows.Forms.Label();
            this.radioButtonEntrata = new System.Windows.Forms.RadioButton();
            this.radioButtonUscita = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDipendenti
            // 
            this.comboBoxDipendenti.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxDipendenti.DropDownHeight = 290;
            this.comboBoxDipendenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDipendenti.Font = new System.Drawing.Font("Consolas", 25F);
            this.comboBoxDipendenti.FormattingEnabled = true;
            this.comboBoxDipendenti.IntegralHeight = false;
            this.comboBoxDipendenti.Location = new System.Drawing.Point(444, 316);
            this.comboBoxDipendenti.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDipendenti.Name = "comboBoxDipendenti";
            this.comboBoxDipendenti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDipendenti.Size = new System.Drawing.Size(364, 46);
            this.comboBoxDipendenti.TabIndex = 0;
            this.comboBoxDipendenti.Visible = false;
            this.comboBoxDipendenti.SelectedIndexChanged += new System.EventHandler(this.comboBoxDipendenti_SelectedIndexChanged);
            // 
            // labelCollaboratore
            // 
            this.labelCollaboratore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCollaboratore.AutoSize = true;
            this.labelCollaboratore.BackColor = System.Drawing.SystemColors.Control;
            this.labelCollaboratore.Font = new System.Drawing.Font("Calibri", 40F);
            this.labelCollaboratore.Location = new System.Drawing.Point(83, 299);
            this.labelCollaboratore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollaboratore.Name = "labelCollaboratore";
            this.labelCollaboratore.Size = new System.Drawing.Size(324, 66);
            this.labelCollaboratore.TabIndex = 1;
            this.labelCollaboratore.Text = "Collaboratore";
            this.labelCollaboratore.Visible = false;
            // 
            // radioButtonEntrata
            // 
            this.radioButtonEntrata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonEntrata.AutoSize = true;
            this.radioButtonEntrata.Font = new System.Drawing.Font("Calibri", 40F);
            this.radioButtonEntrata.Location = new System.Drawing.Point(136, 271);
            this.radioButtonEntrata.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEntrata.Name = "radioButtonEntrata";
            this.radioButtonEntrata.Size = new System.Drawing.Size(204, 70);
            this.radioButtonEntrata.TabIndex = 2;
            this.radioButtonEntrata.Text = "entrata";
            this.radioButtonEntrata.UseVisualStyleBackColor = true;
            this.radioButtonEntrata.CheckedChanged += new System.EventHandler(this.radioButtonEntrata_CheckedChanged);
            // 
            // radioButtonUscita
            // 
            this.radioButtonUscita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonUscita.AutoSize = true;
            this.radioButtonUscita.Font = new System.Drawing.Font("Calibri", 40F);
            this.radioButtonUscita.Location = new System.Drawing.Point(538, 271);
            this.radioButtonUscita.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUscita.Name = "radioButtonUscita";
            this.radioButtonUscita.Size = new System.Drawing.Size(173, 70);
            this.radioButtonUscita.TabIndex = 3;
            this.radioButtonUscita.Text = "uscita";
            this.radioButtonUscita.UseVisualStyleBackColor = true;
            this.radioButtonUscita.CheckedChanged += new System.EventHandler(this.radioButtonUscita_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(136, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Calibri", 40F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(166, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(531, 90);
            this.button1.TabIndex = 6;
            this.button1.Text = "conferma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(11, 503);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(737, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "login admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonUscita);
            this.Controls.Add(this.radioButtonEntrata);
            this.Controls.Add(this.labelCollaboratore);
            this.Controls.Add(this.comboBoxDipendenti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCasa";
            this.Text = "formCasa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDipendenti;
        private System.Windows.Forms.Label labelCollaboratore;
        private System.Windows.Forms.RadioButton radioButtonEntrata;
        private System.Windows.Forms.RadioButton radioButtonUscita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}