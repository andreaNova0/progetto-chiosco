using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace progetto_chiosco
{
    public partial class Form1 : Form
    {
        public SerialPort sp;
        string pathAudio;
        int stato;  // 0 = nessuno davanti alla sensore
                    // 1 = persona davanti, registrazione in corso
                    // 2 = il sensore ha rilevato una persona davanti, deve partire un timer
                    // 3 = ho finito di registrarmi, aspetto 5 secondi prima di far comparire lo screensaver (però se dopo 5 sec è presente una persona faccio comparire l'audio)

        int tempo;   //serve per capire quanti secondi sta davanti una persona
        bool isAttivaHP;

        string[] vettoreScreenSaver;
        int posVettoreImg;
        List<string> listaPersoneCheDevonoEntrare;
        List<string> listaPersoneCheDevonoUscire;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            sp = new SerialPort(elementi.getIstanza().com, int.Parse(elementi.getIstanza().baudRate));
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            pictureBox2.ImageLocation = @".\images\foto1.jpg";
           // pathAudio = elementi.getIstanza().pathAudioArrivo;
            stato = 0;
            tempo = 0;
            posVettoreImg = 0;
            isAttivaHP = false;
            try
            {
               sp.Open(); //apro la porta seriale
            }
            catch (Exception)
            { }
            sp.DtrEnable = true;
            sp.RtsEnable = true;
            pictureBox1.ImageLocation = @".\images\siberg.png";
            pictureCasa.ImageLocation = @".\images\casa.png";
            pictureOspite.ImageLocation = @".\images\ospite.png";

            timerControlloSensore.Start();
            vettoreScreenSaver = new string[] { @".\images\foto1.jpg", @".\images\foto2.jpg", @".\images\foto3.jpg" };
            scegliPathAudio();
            listaPersoneCheDevonoEntrare = new List<string>();
            listaPersoneCheDevonoUscire = new List<string>();
        }

        private void scegliPathAudio()
        {
            DateTime dt = DateTime.Now;
            int ora = dt.Hour;
            if (ora > 0 && ora < 13)
                pathAudio = @"audio\giorno.mp3";
            else if (ora >= 13 && ora < 18)
                pathAudio = @"audio\pomeriggio.mp3";
            else
                pathAudio = @"audio\sera.mp3";
        }


       

        private void pictureCasa_Click(object sender, EventArgs e)
        {
            if (timerScreenSaver.Enabled)
                timerScreenSaver.Stop();
            if (timerFineLogin.Enabled)
                timerFineLogin.Stop();
            formCasa form = new formCasa(this,listaPersoneCheDevonoEntrare,listaPersoneCheDevonoUscire);
            form.ShowDialog();
            tempo = 0;
            timerFineLogin.Start();
            stato = 3;
            isAttivaHP = false; //anche se è attiva, è come se non lo fosse
            //faiComparireScreenSaver();
        }

        private void pictureOspite_Click(object sender, EventArgs e)
        {
            if(timerScreenSaver.Enabled)
                timerScreenSaver.Stop();
            if(timerFineLogin.Enabled)
                timerFineLogin.Stop();
            formOspiti form = new formOspiti();
            form.ShowDialog();
            tempo = 0;
            timerFineLogin.Start();
            stato = 3;
            isAttivaHP = false; //anche se è attiva, è come se non lo fosse
        }

        private void faiComparireScreenSaver()
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureCasa.Visible = false;
            pictureOspite.Visible = false;
            isAttivaHP = false;
            labelCasa.Visible=false;
            labelOspite.Visible=false;
            stato = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)    //timer screen saver
        {
            faiComparireScreenSaver();
            //if(timerFineLogin.Enabled)
            //    timerFineLogin.Stop();
            //timerFineLogin.Start();
        }
        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (stato == 0 || stato == 2)
            {
               faiComparireSchermataLogin();
                if (timerScreenSaver.Enabled)
                    timerScreenSaver.Stop();
                timerScreenSaver.Start();
                stato = 1;
            }            
        }

        private async void runAudio()
        {
            if (isAttivaHP)
                return;
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
            catch (Exception ex) {  }
        }

        private void timerControlloSensore_Tick(object sender, EventArgs e)
        {     
            if (stato == 1 || stato == 3)   //se ci si sta registrando o se qualcuno ha appena finito di registrarsi
                return;
            try
            {
                if (sp.DsrHolding)
                {
                    tempo++;
                }
                else
                    tempo = 0;
            }
            catch (Exception ex){ }
            if (tempo >= 30)
            {
                stato = 1;
                faiComparireSchermataLogin();
            }
        }

        private void faiComparireSchermataLogin()
        {
            runAudio();
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureCasa.Visible = true;
            pictureOspite.Visible = true;
            labelCasa.Visible = true;
            labelOspite.Visible = true;
            if (timerScreenSaver.Enabled)   //se dopo un po' che non si fa niente ricompare l'immagine di sfondo
                timerScreenSaver.Stop();
            timerScreenSaver.Start();
            isAttivaHP = true;
        }

        private void timerFineLogin_Tick(object sender, EventArgs e)
        {
            timerFineLogin.Stop();
            if (sp.DsrHolding)
            {
                faiComparireSchermataLogin();
                stato = 1;
            }
            else
            {
                faiComparireScreenSaver();
                stato = 0;
            }
        }

        private void timerImgChange_Tick(object sender, EventArgs e)
        {
            posVettoreImg++;
            if(posVettoreImg > 2)
                posVettoreImg = 0;
            pictureBox2.ImageLocation = vettoreScreenSaver[posVettoreImg];
        }

      
    }
}
