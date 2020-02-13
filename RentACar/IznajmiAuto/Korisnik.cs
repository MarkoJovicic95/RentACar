using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace IznajmiAuto
{
    [Serializable]
    class Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private string jmbg;
        private DateTime datum_rodjenja;
        private string telefon;
        private string password;

        public override string ToString()
        {
            return ime + " " + prezime + ", JMBG: " + jmbg + ", datum rodjenja: " + datum_rodjenja.ToShortDateString() + ", telefon: " + telefon;
        }

        public void azuriraj(string ime, string prezime, string jmbg, string datum_rodjenja, string telefon)
        {
            string pogresanUnos = "";
            int flag = 0;
            if (ime.Trim() == "")
            {
                pogresanUnos += "Morate uneti ime!" + Environment.NewLine;
                flag = 1;
            }
            if (prezime.Trim() == "")
            {
                pogresanUnos += "Morate uneti prezime!" + Environment.NewLine;
                flag = 1;
            }
            if (!jmbg.All(char.IsDigit) || jmbg.Trim() == "")
            {
                pogresanUnos += "Morate uneti ispravan JMBG!" + Environment.NewLine;
                flag = 1;
            }
            if (!telefon.All(char.IsDigit) || telefon.Trim() == "")
            {
                pogresanUnos += "Morate uneti ispravan telefon!" + Environment.NewLine;
                flag = 1;
            }
            List<Kupac> kupci = new List<Kupac>();
            kupci = Globalne.procitajKupce(Globalne.DatKupac);
            foreach (Kupac k in kupci)
            {
                if (k.Telefon == telefon && this.telefon!=telefon)
                {
                    pogresanUnos += "Uneti telefon vec postoji!" + Environment.NewLine;
                    flag = 1;
                }
            }         
            if(!DateTime.TryParse(datum_rodjenja, out DateTime datum))
            {
                pogresanUnos += "Netacan unos datuma!" + Environment.NewLine;
                flag = 1;
            }

            if (password.Trim() == "")
            {
                pogresanUnos += "Morate uneti lozinku!" + Environment.NewLine;
                flag = 1;
            }
            if (flag == 1)
            {
                MessageBox.Show(pogresanUnos, "Pogresan unos podataka!");
            }
            else
            {
                Ime = ime;
                Prezime = prezime;
                Jmbg = jmbg;
                Datum_rodjenja = datum;
                Telefon = telefon;
            }
        }

        public int Id { get { return id; } set { id = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public string Jmbg { get { return jmbg; } set { jmbg = value; } }
        public DateTime Datum_rodjenja { get { return datum_rodjenja; } set { datum_rodjenja = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }
        public string Password { get { return password; } set { password = value; } }



    }
}
