namespace progetto_chiosco
{
    partial class formOspiti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonEntrata = new System.Windows.Forms.RadioButton();
            this.radioButtonUscita = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.textBoxAzienda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxRicerca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(103, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F);
            this.label2.Location = new System.Drawing.Point(103, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F);
            this.label3.Location = new System.Drawing.Point(104, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Azienda";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F);
            this.label4.Location = new System.Drawing.Point(103, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Persona da ricercare";
            this.label4.Visible = false;
            // 
            // radioButtonEntrata
            // 
            this.radioButtonEntrata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonEntrata.AutoSize = true;
            this.radioButtonEntrata.Font = new System.Drawing.Font("Calibri", 20F);
            this.radioButtonEntrata.Location = new System.Drawing.Point(94, 252);
            this.radioButtonEntrata.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEntrata.Name = "radioButtonEntrata";
            this.radioButtonEntrata.Size = new System.Drawing.Size(112, 37);
            this.radioButtonEntrata.TabIndex = 4;
            this.radioButtonEntrata.Text = "entrata";
            this.radioButtonEntrata.UseVisualStyleBackColor = true;
            this.radioButtonEntrata.CheckedChanged += new System.EventHandler(this.radioButtonEntrata_CheckedChanged);
            // 
            // radioButtonUscita
            // 
            this.radioButtonUscita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonUscita.AutoSize = true;
            this.radioButtonUscita.Checked = true;
            this.radioButtonUscita.Font = new System.Drawing.Font("Calibri", 20F);
            this.radioButtonUscita.Location = new System.Drawing.Point(610, 252);
            this.radioButtonUscita.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUscita.Name = "radioButtonUscita";
            this.radioButtonUscita.Size = new System.Drawing.Size(97, 37);
            this.radioButtonUscita.TabIndex = 5;
            this.radioButtonUscita.TabStop = true;
            this.radioButtonUscita.Text = "uscita";
            this.radioButtonUscita.UseVisualStyleBackColor = true;
            this.radioButtonUscita.CheckedChanged += new System.EventHandler(this.radioButtonUscita_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(116, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Font = new System.Drawing.Font("Calibri", 20F);
            this.textBoxNome.Location = new System.Drawing.Point(417, 323);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(326, 40);
            this.textBoxNome.TabIndex = 8;
            this.textBoxNome.Visible = false;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCognome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCognome.Font = new System.Drawing.Font("Calibri", 20F);
            this.textBoxCognome.Location = new System.Drawing.Point(417, 384);
            this.textBoxCognome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(326, 40);
            this.textBoxCognome.TabIndex = 9;
            this.textBoxCognome.Visible = false;
            this.textBoxCognome.TextChanged += new System.EventHandler(this.textBoxCognome_TextChanged);
            // 
            // textBoxAzienda
            // 
            this.textBoxAzienda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAzienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAzienda.Font = new System.Drawing.Font("Calibri", 20F);
            this.textBoxAzienda.Location = new System.Drawing.Point(417, 452);
            this.textBoxAzienda.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAzienda.Name = "textBoxAzienda";
            this.textBoxAzienda.Size = new System.Drawing.Size(326, 40);
            this.textBoxAzienda.TabIndex = 10;
            this.textBoxAzienda.Visible = false;
            this.textBoxAzienda.TextChanged += new System.EventHandler(this.textBoxAzienda_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Calibri", 30F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(233, 1031);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "conferma";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(8, 1000);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F);
            this.label5.Location = new System.Drawing.Point(103, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "chi sei?";
            this.label5.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 20F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(417, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 41);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Location = new System.Drawing.Point(12, 647);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Calibri", 25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(211, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 67);
            this.button2.TabIndex = 17;
            this.button2.Text = "conferma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxRicerca
            // 
            this.comboBoxRicerca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxRicerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRicerca.Font = new System.Drawing.Font("Calibri", 20F);
            this.comboBoxRicerca.FormattingEnabled = true;
            this.comboBoxRicerca.Items.AddRange(new object[] {
            "Ufficio tecnico",
            "LAB",
            "Ufficio acquisti",
            "Amministrazione",
            "Direzione",
            "Nessuno"});
            this.comboBoxRicerca.Location = new System.Drawing.Point(417, 512);
            this.comboBoxRicerca.Name = "comboBoxRicerca";
            this.comboBoxRicerca.Size = new System.Drawing.Size(326, 41);
            this.comboBoxRicerca.TabIndex = 18;
            this.comboBoxRicerca.Visible = false;
            this.comboBoxRicerca.SelectedIndexChanged += new System.EventHandler(this.comboBoxRicerca_SelectedIndexChanged);
            // 
            // formOspiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 749);
            this.Controls.Add(this.comboBoxRicerca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAzienda);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonUscita);
            this.Controls.Add(this.radioButtonEntrata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formOspiti";
            this.Text = "formOspiti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonEntrata;
        private System.Windows.Forms.RadioButton radioButtonUscita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.TextBox textBoxAzienda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxRicerca;
    }
}