using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_chiosco
{
    internal class persona
    {
        public string nome;
        string entrataUscita;
        public string date;
        public string azienda;
        public string motivo;

        public persona(string nome, string entrataUscita, string date, string azienda, string motivo)
        {
            this.nome = nome;
            this.date = date;
            this.entrataUscita = entrataUscita ;
            this.azienda = azienda ;
            this.motivo = motivo ;
        }

        public string toCsv()
        {
            return nome + ";" + entrataUscita + ";" + date + ";" + azienda + ";" + motivo;
        }

        static public persona Parse(string s)
        {
            string[] tmp = s.Split(';');
            persona p = new persona(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]);
            return p;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
