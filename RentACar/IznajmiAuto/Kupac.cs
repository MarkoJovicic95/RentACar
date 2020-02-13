using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmiAuto
{
    [Serializable]
    class Kupac : Korisnik
    {
        public Kupac(string ime, string prezime, string jmbg, DateTime datum_rodjenja, string telefon, string password)
        {
            Id = 0;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Datum_rodjenja = datum_rodjenja;
            Telefon = telefon;
            Password = password;
        }


        public void upisiKupca(string imeDatoteke)
        {
                List<Kupac> listaKupaca = new List<Kupac>();
                BinaryFormatter binform = new BinaryFormatter();
                if (File.Exists(imeDatoteke))
                {
                    FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.ReadWrite);
                    listaKupaca.Clear();
                    listaKupaca = binform.Deserialize(fs) as List<Kupac>;

                    this.Id = listaKupaca[listaKupaca.Count() - 1].Id + 1;
                    listaKupaca.Add(this);
                    fs.Seek(0, SeekOrigin.Begin);
                    binform.Serialize(fs, listaKupaca);
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(imeDatoteke, FileMode.Create, FileAccess.Write);
                    this.Id = 1;
                    listaKupaca.Add(this);
                    binform.Serialize(fs, listaKupaca);
                    fs.Close();
                }
        }
    }
}
