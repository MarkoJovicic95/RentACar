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
    class Automobil
    {
        private int id;
        private string marka;
        private string model;
        private int godiste;
        private int kubikaza;
        private string pogon;
        private string menjac;
        private string karoserija;
        private string gorivo;
        private int brojVrata;
        


        public Automobil(string marka, string model, int godiste, int kubikaza, string pogon, string menjac, string karoserija, string gorivo, int brojVrata)
        {
            this.id = 0;
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            this.kubikaza = kubikaza;
            this.pogon = pogon;
            this.menjac = menjac;
            this.karoserija = karoserija;
            this.gorivo = gorivo;
            this.brojVrata = brojVrata;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Godiste { get { return godiste; } set { godiste = value; } }
        public int Kubikaza { get { return kubikaza; } set { kubikaza = value; } }
        public string Pogon { get { return pogon; } set { pogon = value; } }
        public string Menjac { get { return menjac; } set { menjac = value; } }
        public string Karoserija { get { return karoserija; } set { karoserija = value; } }
        public string Gorivo { get { return gorivo; } set { gorivo = value; } }
        public int BrojVrata { get { return brojVrata; } set { brojVrata = value; } }


        public override string ToString()
        {
            return marka + " " + model + ", " + godiste + ", " + kubikaza + " kubika, " + pogon + " pogon, " + menjac + " menjac, " + karoserija + ", " + gorivo + ", " + brojVrata + " vrata";
        }

        public void upisiAutomobil(string imeDatoteke)
        {
            List<Automobil> automobils = new List<Automobil>();
            BinaryFormatter binform = new BinaryFormatter();
            if (File.Exists(imeDatoteke))
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Open, FileAccess.ReadWrite);
                automobils.Clear();
                automobils = binform.Deserialize(fs) as List<Automobil>;

                this.Id = automobils[automobils.Count() - 1].Id + 1;
                automobils.Add(this);
                fs.Seek(0, SeekOrigin.Begin);
                binform.Serialize(fs, automobils);
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(imeDatoteke, FileMode.Create, FileAccess.Write);
                this.Id = 1;
                automobils.Add(this);
                binform.Serialize(fs, automobils);
                fs.Close();
            }
        }
        public void azuriraj(string marka, string model, string godiste, string kubikaza, string pogon, string menjac, string karoserija, string gorivo, string brojVrata)
        {
            string pogresanUnos = "";
            int flag = 0;
            if (marka.Trim() == "")
            {
                pogresanUnos += "Morate uneti marku automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (model.Trim() == "")
            {
                pogresanUnos += "Morate uneti model automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (godiste.Trim() == "" || !godiste.All(char.IsDigit) || int.Parse(godiste) > DateTime.Today.Year)
            {
                pogresanUnos += "Morate uneti korektno godiste automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (kubikaza.Trim() == "" || !kubikaza.All(char.IsDigit))
            {
                pogresanUnos += "Morate uneti ispravno kubikazu!" + Environment.NewLine;
                flag = 1;
            }
            if (pogon.Trim() == "")
            {
                pogresanUnos += "Morate uneti pogon!" + Environment.NewLine;
                flag = 1;
            }
            if (menjac.Trim() == "")
            {
                pogresanUnos += "Morate uneti vrstu menjaca!" + Environment.NewLine;
                flag = 1;
            }
            if (karoserija.Trim() == "")
            {
                pogresanUnos += "Morate uneti karoseriju!" + Environment.NewLine;
                flag = 1;
            }
            if (gorivo.Trim() == "")
            {
                pogresanUnos += "Morate uneti vrstu goriva!" + Environment.NewLine;
                flag = 1;
            }
            if (brojVrata.Trim() == "" || !brojVrata.All(char.IsDigit))
            {
                pogresanUnos += "Morate uneti ispravno broj vrata!" + Environment.NewLine;
                flag = 1;
            }
            if (flag == 1)
            {
                MessageBox.Show(pogresanUnos, "Pogresan unos podataka!");
            }
            else
            {
                this.marka = marka;
                this.model = model;
                this.godiste = int.Parse(godiste);
                this.kubikaza = int.Parse(kubikaza);
                this.pogon = pogon;
                this.menjac = menjac;
                this.karoserija = karoserija;
                this.gorivo = gorivo;
                this.brojVrata = int.Parse(brojVrata);
            }

        }

    }
}
