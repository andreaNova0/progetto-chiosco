using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Threading;

namespace progetto_chiosco
{
    public partial class formCasa : Form
    {
        string pathExcel;
        Form1 f1;
        List<string> listaPersoneCheDevonoEntrare;
        List<string> listaPersoneCheDevonoUscire;

        public formCasa(Form1 form, List<string> listaPersoneCheDevonoEntrare, List<string> listaPersoneCheDevonoUscire)
        {
            InitializeComponent();

            pictureBox1.ImageLocation = @".\images\siberg.png";
            pictureBox2.ImageLocation = @".\images\indietro.png";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pathExcel = elementi.getIstanza().pathExcel;
            this.f1 = form;
            timer1.Start();
            this.listaPersoneCheDevonoEntrare = listaPersoneCheDevonoEntrare;
            this.listaPersoneCheDevonoUscire = listaPersoneCheDevonoUscire;
            inizializzaListaEntrate();
            
        }

        private void inizializzaListaEntrate()
        {
            using(StreamReader sr = new StreamReader("dipendenti.txt")) 
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    listaPersoneCheDevonoEntrare.Add(s);
                }
            }
        }

        private void inizializzaComboBox(List<string> lista)
        {
            comboBoxDipendenti.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                comboBoxDipendenti.Items.Add(lista[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controlli())
            {
                bool stato;
                string s= "";

                s = comboBoxDipendenti.Text + ";";
                if (radioButtonEntrata.Checked)
                {
                    s += "entrata;";
                    stato = true;
                    string dipentente = comboBoxDipendenti.Text;
                    listaPersoneCheDevonoEntrare.Remove(dipentente);
                    listaPersoneCheDevonoUscire.Add(dipentente);
                }
                else
                {
                    s += "uscita;";
                    stato = false;
                    string dipentente = comboBoxDipendenti.Text;
                    listaPersoneCheDevonoEntrare.Add(dipentente);
                    listaPersoneCheDevonoUscire.Remove(dipentente);
                }

                DateTime dt = DateTime.Now;
                s += dt.ToString();

                using(StreamWriter sw =new StreamWriter("accessi.txt",true))
                {
                    sw.WriteLine(s);
                }
                Thread th1 = new Thread(new ThreadStart(CsvToExcel));

                if(timer1.Enabled)  
                    timer1.Stop();

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

        private bool controlli()
        {
            if (!radioButtonEntrata.Checked && !radioButtonUscita.Checked || comboBoxDipendenti.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CsvToExcel()
        {

            if (File.Exists(pathExcel))
                File.Delete(pathExcel);

            string csvFileName = @"accessi.txt";

            string worksheetsName = "ACCESSI";


            var format = new ExcelTextFormat();
            format.Delimiter = ',';
            format.EOL = "\r";              // DEFAULT IS "\r\n";
                                            // format.TextQualifier = '"';


            int riga = 1;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetsName);
                
                
                using(StreamReader sr = new StreamReader(csvFileName))
                {

                    while (!sr.EndOfStream)
                    {
                        char colonna = 'A';

                        string s = sr.ReadLine();
                        string[] vettoreParole = s.Split(';');
                        if(vettoreParole.Length - 1 == 5)
                        {
                            s = s.Substring(0,s.Length - 2);
                            vettoreParole = s.Split(';');
                        }
                        for (int i = 0; i < vettoreParole.Length ;i++)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
                timer1.Stop();
            formAdmin form = new formAdmin(f1.sp);
            form.ShowDialog();
            if (f1.sp == form.sp)
                return;
            f1.sp = form.sp;
            f1.sp.DtrEnable = true;
            f1.sp.RtsEnable = true;
            try
            {
                f1.sp.Open(); //apro la porta seriale
            }
            catch (Exception)
            { }
            if(!timer1.Enabled)
                timer1.Start();
        }

        private void comboBoxDipendenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonEntrata_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
            inizializzaComboBox(listaPersoneCheDevonoEntrare);
            labelCollaboratore.Visible = true;
            comboBoxDipendenti.Visible = true;
        }

        private void radioButtonUscita_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
            inizializzaComboBox(listaPersoneCheDevonoUscire);
            labelCollaboratore.Visible = true;
            comboBoxDipendenti.Visible = true;
        }
    }
}
