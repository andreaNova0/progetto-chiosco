using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_chiosco
{
    public partial class formFinale : Form
    {
        string path;
        string pathAudioCorretto;
        string pathAudioSbagliato;
        public formFinale(string path, bool entrataUscita = true)  //true = entrata, false = uscita
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //pathAudioCorretto = elementi.getIstanza().pathAudioSuccesso;
            //pathAudioSbagliato = elementi.getIstanza().pathAudioErrore;
            pathAudioSbagliato = @".\audio\errore.mp3";
            this.path = path;
            pictureBox1.ImageLocation = path;
            if (path == @".\images\bene.jpg")
            {
                label1.Text = "Registrazione effettuata con successo";
                if (entrataUscita)
                    pathAudioCorretto = @".\audio\entrata.mp3";
                else
                    pathAudioCorretto = @".\audio\uscita.mp3";
                timer1.Start();
            }
            else
            {
                label1.Text = "Errore durante la registrazione";
                pictureBox2.Visible = true;
                pictureBox2.ImageLocation = @".\images\indietro.png";

            }
            formFinale tmp = this;
            WindowState = FormWindowState.Maximized;
            label1.Left = ((tmp.Size.Width - label1.Width) / 2);
            runAudio();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void runAudio()
        {
            string pathAudio = "";
            if(path == @".\images\bene.jpg")
                pathAudio = pathAudioCorretto;
            else
                pathAudio = pathAudioSbagliato;

            try
            {
                using (var audioFile = new AudioFileReader(pathAudio))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // Attendi che la riproduzione finisca
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        //System.Threading.Thread.Sleep(1000);
                        await Task.Delay(1000);
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
