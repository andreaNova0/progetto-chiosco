using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace progetto_chiosco
{
    public class elementi
    {
        public string password;                 // --> 0
        public string com;                      // --> 1
        public string baudRate;                 // --> 2
        public string pathExcel;                // --> 3
        //public string pathAudioArrivo;          // --> 4
        //public string pathAudioSuccesso;        // --> 5
        //public string pathAudioErrore;          // --> 6

        private static elementi istanza = null;

        private elementi()
        {
            using(StreamReader sr = new StreamReader("proprietà.txt"))
            {
                try
                {
                    string[] vettore = sr.ReadToEnd().Split(';');
                    password = vettore[0];
                    com = vettore[1];
                    baudRate = vettore[2];
                    pathExcel = vettore[3];
                    //pathAudioArrivo = vettore[4];
                    //pathAudioSuccesso = vettore[5];
                    //pathAudioErrore = vettore[6];
                }
                catch { }
            }
        }

        public static elementi getIstanza()
        {
            if (istanza == null)
                istanza = new elementi();
            return istanza;

        }

        public void salva()
        {
            using (StreamWriter sw = new StreamWriter("proprietà.txt"))
            {
                string s = password + ";" + com + ";" + baudRate + ";" + pathExcel + ";" /*+ pathAudioArrivo + ";" + pathAudioSuccesso + ";" + pathAudioErrore*/;
                sw.WriteLine(s);
            }
        }

    }
}
