using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_chiosco
{
    public partial class formAdmin : Form
    {
        //string password;
        //string com;
        List<string> listaDipendenti;
        //string path;
        public SerialPort sp;
        elementi el;
        public formAdmin(SerialPort sp)
        {
            InitializeComponent();
            this.sp = sp;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            pictureBox1.ImageLocation = @".\images\siberg.png";
            pictureBox2.ImageLocation = @".\images\indietro.png";
            listaDipendenti = new List<string>();

            el = elementi.getIstanza();
            

            inizializzaLista();
            //inizializzaAttributi();

            textBoxCom.Text = el.com.ElementAt(3) + "";
            textBoxPathAttuale.Text = el.pathExcel;
            //textBoxAudioErrore.Text = el.pathAudioErrore;
            //textBoxAudioArrivo.Text = el.pathAudioArrivo;
            //textBoxAudioSuccesso.Text = el.pathAudioSuccesso;
            textBoxBaudRate.Text = el.baudRate;

            pictureBox3.ImageLocation = @".\images\siberg.png";
            pictureBox4.ImageLocation = @".\images\indietro.png";
            pictureBox5.ImageLocation = @".\images\siberg.png";
            pictureBox6.ImageLocation = @".\images\indietro.png";
            pictureBox7.ImageLocation = @".\images\siberg.png";
            pictureBox8.ImageLocation = @".\images\indietro.png";
            pictureBox9.ImageLocation = @".\images\siberg.png";
            pictureBox10.ImageLocation = @".\images\indietro.png";
        }

        private void inizializzaLista()
        {
            if (!File.Exists("proprietà.txt"))
                return;
            using (StreamReader sr = new StreamReader("dipendenti.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    listaDipendenti.Add(s);
                }
            }
            for (int i = 0; i < listaDipendenti.Count; i++)  
                comboBox1.Items.Add(listaDipendenti[i]);
            
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (textBox1.Text == el.password)
                {
                    label1.Visible = false;
                    textBox1.Visible = false;
                    tabControl1.Visible = true;
                }
                else
                {
                    formFinale form = new formFinale(@".\images\male.jpg");
                    form.ShowDialog();           
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(controlli())
            {
                el.password = textBoxNewPass.Text;
                MessageBox.Show("Password aggiornata");
                textBoxPassAttuale.Text = "";
                textBoxNewPass.Text = "";
                textBoxConferma.Text = "";
            }
        }

        private bool controlli()
        {
            if(textBoxPassAttuale.Text != el.password)
            {
                MessageBox.Show("Password attuale non corretta");
                return false;
            }

            if (textBoxNewPass.Text == string.Empty)
            {
                MessageBox.Show("Inserire la nuova password");
                return false;
            }

            if (textBoxConferma.Text == string.Empty)
            {
                MessageBox.Show("Inserire la conferma della nuova password");
                return false;
            }

            if (textBoxConferma.Text != textBoxNewPass.Text)
            {
                MessageBox.Show("La nuova password non coincide");
                return false;
            }

            if (textBoxNewPass.Text == el.password)
            {
                MessageBox.Show("La nuova password non può essere uguale alla precedente");
                return false;
            }
           
           

            return true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            el.salva();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            el.salva();
            Close();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxAggiungiDip.Text == string.Empty)
            {
                MessageBox.Show("Inserire il nome del dipendente");
                return;
            }
            listaDipendenti.Add(textBoxAggiungiDip.Text);
            comboBox1.Items.Add(textBoxAggiungiDip.Text);

            using (StreamWriter sw = new StreamWriter("dipendenti.txt", true))
                sw.WriteLine(textBoxAggiungiDip.Text);
            
            MessageBox.Show("Dipendente aggiunto con successo");
            textBoxAggiungiDip.Text = "";
        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un dipendente da rimuovere");
                return;
            }
            listaDipendenti.Remove(comboBox1.Text);
            using (StreamWriter sw = new StreamWriter("dipendenti.txt"))
            {
                for(int i = 0; i < listaDipendenti.Count; i++)
                {
                    sw.WriteLine(listaDipendenti[i]);
                }    
            }
            MessageBox.Show("Dipendente rimosso con successo");
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = string.Empty;
        }

        private void buttonSalvaCom_Click(object sender, EventArgs e)
        {
            salvaCom();
            salvaBaudRate();
        }

        private void salvaCom()
        {
            if (textBoxCom.Text == string.Empty)
            {
                MessageBox.Show("Inserire un numero di porta COM valido");
                return;
            }
            if ("COM" + textBoxCom.Text == el.com)
            {
                MessageBox.Show("La nuova porta COM non può essere uguale alla precedente");
                return;
            }
            int num = 0;
            bool ris = int.TryParse(textBoxCom.Text, out num);
            if (ris == false)
            {
                MessageBox.Show("Inserire un numero");
                return;
            }
            el.com = "COM" + textBoxCom.Text;
            sp = new SerialPort(el.com, 57000);
            //salvaTutto();
            MessageBox.Show("Porta COM cambiata");
        }

        private void salvaBaudRate()
        {
            int num = 0;
            bool ris = int.TryParse(textBoxBaudRate.Text, out num);
            if (ris == false)
            {
                MessageBox.Show("Inserire un numero valido nel baud rate");
                return;
            }
            el.baudRate =textBoxBaudRate.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == "")
                return;
            string fileName = ofd.FileName;
            el.pathExcel = fileName;
            textBoxPathAttuale.Text = fileName;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            el.salva();
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            el.salva();
            Close();
        }

        private void textBoxPathAttuale_TextChanged(object sender, EventArgs e)
        {
            textBoxPathAttuale.Text = el.pathExcel;
        }

        private void textBoxAudioArrivo_TextChanged(object sender, EventArgs e)
        {
            //textBoxAudioArrivo.Text = el.pathAudioArrivo;
        }

        private void textBoxAudioSuccesso_TextChanged(object sender, EventArgs e)
        {
                //textBoxAudioSuccesso.Text = el.pathAudioSuccesso;
        }

        private void textBoxAudioErrore_TextChanged(object sender, EventArgs e)
        {
            //textBoxAudioErrore.Text = el.pathAudioErrore;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            el.pathExcel = textBoxPathAttuale.Text;
            //el.pathAudioArrivo = textBoxAudioArrivo.Text;
            //el.pathAudioSuccesso = textBoxAudioSuccesso.Text;
            //el.pathAudioErrore = textBoxAudioErrore.Text;
            el.salva();
        }

        private void buttonAudioArrivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == "")
                return;
            string fileName = ofd.FileName;
            //el.pathAudioArrivo = fileName;
            textBoxAudioArrivo.Text = fileName;
        }

        private void buttonAudioSuccesso_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == "")
                return;
            string fileName = ofd.FileName;
            //el.pathAudioSuccesso = fileName;
            //textBoxAudioSuccesso.Text = fileName;
        }

        private void buttonAudioErrore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == "")
                return;
            string fileName = ofd.FileName;
            //el.pathAudioErrore = fileName;
            textBoxAudioErrore.Text = fileName;
        }
    }
}
