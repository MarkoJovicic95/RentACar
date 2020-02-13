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
    static class Globalne
    {       
        private static Administrator glavniAdmin = new Administrator("Marko", "Jovicic", "291299577241", DateTime.Parse("29/12/1995"), "admin", "admin");
        public static Administrator GlavniAdmin { get { return glavniAdmin; } }

        private static Administrator trenutniAdmin;
        public static Administrator TrenutniAdmin { get { return trenutniAdmin; } set { trenutniAdmin = value; } }

        private static Kupac trenutniKupac;
        public static Kupac TrenutniKupac { get { return trenutniKupac; } set { trenutniKupac = value; } }


        private static string datAdmin = "Administratori.bin";
        public static string DatAdmin { get { return datAdmin; } }

        private static string datKupac = "Kupci.bin";
        public static string DatKupac { get { return datKupac; } }

        private static string datAutomobili = "Automobili.bin";
        public static string DatAutomobili { get { return datAutomobili; } }

        private static string datPonude = "Ponude.bin";
        public static string DatPonude { get { return datPonude; } }

        private static string datRezervacije = "Rezervacije.bin";
        public static string DatRezervacije { get { return datRezervacije; } }

        private static bool praviAdmina;
        public static bool PraviAdmina { get { return praviAdmina; } set { praviAdmina = value; } }

        private static bool adminPraviKupca;
        public static bool AdminPraviKupca { get { return adminPraviKupca; } set { adminPraviKupca = value; } }

        private static bool azurirajKupca;
        public static bool AzurirajKupca { get { return azurirajKupca; } set { azurirajKupca = value; } }

        private static bool azurirajAuto;
        public static bool AzurirajAuto { get { return azurirajAuto; } set { azurirajAuto = value; } }

        private static bool azurirajPonudu;
        public static bool AzurirajPonudu { get { return azurirajPonudu; } set { azurirajPonudu = value; } }

        public static List<Administrator> procitajAdmine(string imeDatoteke)
        {
            List<Administrator> administrators = new List<Administrator>();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Read);
                BinaryFormatter binform = new BinaryFormatter();
                administrators = binform.Deserialize(fs) as List<Administrator>;
                fs.Close();
                return administrators;
            }
            else
            {
                return administrators;
            }            
        }

        public static List<Kupac> procitajKupce(string imeDatoteke)
        {
            List<Kupac> kupci = new List<Kupac>();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Read);
                BinaryFormatter binform = new BinaryFormatter();
                kupci = binform.Deserialize(fs) as List<Kupac>;
                fs.Close();
                return kupci;
            }
            else
            {
                return kupci;
            }
        }
        public static void upisiKupce(List<Kupac> kupci, string imeDatoteke)
        {
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);       //brise sve sto je pre toga bilo u datoteci
                binform.Serialize(fs, kupci);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Fajl " + imeDatoteke + " ne postoji!", "Greska");
            }
        }

        public static List<Automobil> procitajAutomobile(string imeDatoteke)
        {
            List<Automobil> automobils = new List<Automobil>();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Read);
                BinaryFormatter binform = new BinaryFormatter();
                automobils = binform.Deserialize(fs) as List<Automobil>;
                fs.Close();
                return automobils;
            }
            else
            {
                return automobils;
            }
        }
        public static void upisiAutomobile(List<Automobil> automobils, string imeDatoteke)
        {
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);       //brise sve sto je pre toga bilo u datoteci
                binform.Serialize(fs, automobils);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Fajl " + imeDatoteke + " ne postoji!", "Greska");
            }
        }

        public static List<Ponuda> procitajPonude(string imeDatoteke)
        {
            List<Ponuda> ponude = new List<Ponuda>();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Read);
                BinaryFormatter binform = new BinaryFormatter();
                ponude = binform.Deserialize(fs) as List<Ponuda>;
                fs.Close();
                return ponude;
            }
            else
            {
                return ponude;
            }
        }
        public static void upisiPonude(List<Ponuda> ponude, string imeDatoteke)
        {
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);       //brise sve sto je pre toga bilo u datoteci
                binform.Serialize(fs, ponude);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Fajl " + imeDatoteke + " ne postoji!", "Greska");
            }
        }


        public static List<Rezervacija> procitajRezervacije(string imeDatoteke)
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Read);
                BinaryFormatter binform = new BinaryFormatter();
                rezervacije = binform.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
                return rezervacije;
            }
            else
            {
                return rezervacije;
            }
        }
        public static void upisiRezervacije(List<Rezervacija> rezervacije, string imeDatoteke)
        {
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);       //brise sve sto je pre toga bilo u datoteci
                binform.Serialize(fs, rezervacije);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Fajl " + imeDatoteke + " ne postoji!", "Greska");
            }
        }
    }
}
