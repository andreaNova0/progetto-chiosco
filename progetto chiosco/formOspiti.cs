using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_chiosco
{
    public partial class formOspiti : Form
    {
        string pathExcel;
        List<persona> listaPersone = new List<persona>();
        public formOspiti()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @".\images\siberg.png";
            radioButtonEntrata.Checked = false;
            radioButtonUscita.Checked = false;
            pictureBox3.ImageLocation = @".\images\indietro.png";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;


            inizializzaLista();
            for(int i = 0; i < listaPersone.Count; i++)
            {
                comboBox1.Items.Add(listaPersone[i].ToString());
            }

            inizializzaPathExcel();
            timer1.Start();
        }


        private void inizializzaPathExcel()
        {
            using (StreamReader sr = new StreamReader("proprietà.txt"))
            {
                pathExcel = sr.ReadLine().Split(';')[3];
            }
        }

        private void inizializzaLista()
        {       
            List<persona> personeEntrate = new List<persona>();
            List<persona> personeUscite = new List<persona>();

            using (StreamReader sr = new StreamReader("accessi.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] vettoreParole = s.Split(';');
                    if (vettoreParole.Length - 1 == 5)
                    {
                        if (s.ElementAt(s.Length - 1) == '0')
                            personeEntrate.Add(persona.Parse(s));
                        else if (s.ElementAt(s.Length - 1) == '1')
                            personeUscite.Add(persona.Parse(s));
                    }
     
                }

                for(int i = 0; i < personeEntrate.Count; i++)
                {
                    bool stato = false;
                    for(int j = 0; j < personeUscite.Count; j++)
                    {
                        if (personeEntrate[i].nome == personeUscite[j].nome && personeEntrate[i].motivo == personeUscite[j].motivo && personeEntrate[i].azienda == personeUscite[j].azienda)
                        {
                            stato = true;
                        }
                    }
                    if (!stato)
                        comboBox1.Items.Add(personeEntrate[i]);
                }
            }
        }


        private void CsvToExcel()
        {

            if (File.Exists(pathExcel))
                File.Delete(pathExcel);

            string csvFileName = @"accessi.txt";

            string worksheetName = "ACCESSI";

            int riga = 1;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetName);


                using (StreamReader sr = new StreamReader(csvFileName))
                {

                    while (!sr.EndOfStream)
                    {
                        char colonna = 'A';

                        string s = sr.ReadLine();
                        if(s.ElementAt(s.Length - 1) == '0' || s.ElementAt(s.Length - 1) == '1')
                            s = s.Substring(0, s.Length - 2);
                        string[] vettoreParole = s.Split(';');
                        for (int i = 0; i < vettoreParole.Length; i++)
                        {
                            
                            string pos = colonna + "" + riga;
                            worksheet.Cells[pos].LoadFromText(vettoreParole[i]);
                            colonna++;

                        }
                        riga++;
                    }
                }
                worksheet.Cells.AutoFitColumns();
                package.Save();




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
        }

        private bool controlli()
        {
            if (textBoxNome.Text == string.Empty)
                return false;
            if(textBoxCognome.Text == string.Empty)
                return false;
            if(textBoxAzienda.Text == string.Empty)
                return false;
            if(comboBoxRicerca.SelectedIndex == -1)
                return false;
            if(!radioButtonEntrata.Checked && !radioButtonUscita.Checked)
                return false;
            return true;
        }


        private void radioButtonEntrata_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEntrata.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBoxNome.Visible = true;
                textBoxCognome.Visible = true;
                textBoxAzienda.Visible = true;
                comboBoxRicerca.Visible = true;

                label5.Visible = false;
                comboBox1.Visible = false;
                if(timer1.Enabled)
                {
                    timer1.Stop();
                    timer1.Start();
                }
            }
        }

        private void radioButtonUscita_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUscita.Checked == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBoxNome.Visible = false;
                textBoxCognome.Visible = false;
                textBoxAzienda.Visible = false;
                comboBoxRicerca.Visible = false;

                label5.Visible = true;
                comboBox1.Visible = true;
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    timer1.Start();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButtonEntrata.Checked)
            {
                if (controlli())
                {
                    bool stato;
                    string s = textBoxNome.Text + " " + textBoxCognome.Text + ";";
                    if (radioButtonEntrata.Checked)
                    {
                        s += "entrata;";
                        stato = true;
                    }
                    else
                    {
                        s += "uscita;";
                        stato = false;
                    }

                    DateTime dt = DateTime.Now;

                    s += dt.ToString() + ";";
                    s += textBoxAzienda.Text + ";" + comboBoxRicerca.Text + ";";

                    s += "0";
                    using (StreamWriter sw = new StreamWriter("accessi.txt", true))
                    {
                        sw.WriteLine(s);
                    }

                    Thread th1 = new Thread(new ThreadStart(CsvToExcel));

                    formFinale form = new formFinale(@".\images\bene.jpg",stato);
                    form.ShowDialog();

                    this.Close();
                }

                else
                {
                    formFinale form = new formFinale(@".\images\male.jpg");
                    form.ShowDialog();
                }
            }
            else if(radioButtonUscita.Checked)
            {

                if(controlliUscita())
                {
                    persona p = comboBox1.SelectedItem as persona;
                    p.date = DateTime.Now.ToString();
                    string s = p.toCsv() + ";1";


                    using (StreamWriter sw = new StreamWriter("accessi.txt", true))
                    {
                        sw.WriteLine(s);
                    }
                    Thread th1 = new Thread(new ThreadStart(CsvToExcel));

                    formFinale form = new formFinale(@".\images\bene.jpg",false);
                    form.ShowDialog();

                    this.Close(); 
                }
                else
                {
                    formFinale form = new formFinale(@".\images\male.jpg");
                    form.ShowDialog();
                }
            
            }
            else
            {
                formFinale form = new formFinale(@".\images\male.jpg");
                form.ShowDialog();
            }
           
        }

        private bool controlliUscita()
        {
            if (comboBox1.SelectedIndex == -1)
                return false;
            if (radioButtonUscita.Checked == false)
                return false;
            return true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void textBoxCognome_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void textBoxAzienda_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void textBoxMotivo_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void comboBoxRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }
    }


}

