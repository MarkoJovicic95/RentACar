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
    class Administrator : Korisnik
    {
        public Administrator(string ime, string prezime, string jmbg, DateTime datum_rodjenja, string telefon, string password)
        {
            Id = 0;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Datum_rodjenja = datum_rodjenja;
            Telefon = telefon;
            Password = password;
        }


        public void upisiAdmina(string imeDatoteke)
        {
            List<Administrator> listaAdmina = new List<Administrator>();
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.ReadWrite);
                listaAdmina.Clear();
                listaAdmina = binform.Deserialize(fs) as List<Administrator>;

                this.Id = listaAdmina[listaAdmina.Count() - 1].Id + 1;
                listaAdmina.Add(this);
                fs.Seek(0, SeekOrigin.Begin);
                binform.Serialize(fs, listaAdmina);
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Create, FileAccess.Write);
                this.Id = 1;
                listaAdmina.Add(this);
                binform.Serialize(fs, listaAdmina);
                fs.Close();
            }
        }



    }
}
