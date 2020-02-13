using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmiAuto
{
    public partial class FormAzurirajRezervacije : Form
    {
        public FormAzurirajRezervacije()
        {
            InitializeComponent();
        }
        List<Rezervacija> rezervacije;
        private void FormAzurirajRezervacije_Load(object sender, EventArgs e)
        {
            rezervacije = Globalne.procitajRezervacije(Globalne.DatRezervacije);
            lblPrijavljen.Text += Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
            List<Kupac> kupci = Globalne.procitajKupce(Globalne.DatKupac);
            foreach (Kupac k in kupci)
                cbKupac.Items.Add(k);
            dateOd.Value = DateTime.Today;
            
            dateDo.Value = DateTime.Today;
            
        }

        private void lblOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormAdmin frm = new FormAdmin();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void cbKupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKupac.SelectedIndex != -1)
            {
                listBox1.Items.Clear();
                Kupac k = (Kupac)cbKupac.SelectedItem;               
                foreach (Rezervacija r in rezervacije)
                    if (r.IdKupac == k.Id)
                        listBox1.Items.Add(r);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rezervacija r = (Rezervacija)listBox1.SelectedItem;
            if (listBox1.SelectedIndex != -1)
            {
                dateOd.Value = r.DatumOd;
                dateDo.Value = r.DatumDo;
                txtCena.Text = r.Cena.ToString();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                rezervacije.Remove((Rezervacija)listBox1.SelectedItem);
                Globalne.upisiRezervacije(rezervacije, Globalne.DatRezervacije);
                dateOd.Value = DateTime.Today;
                dateDo.Value = DateTime.Today;
                txtCena.Text = "";
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Uspesno obrisana rezervacija");
            }
            else
                MessageBox.Show("Rezervacija nije selektovana!","Greska");
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            foreach (Rezervacija r in rezervacije)
            {
                if (r.Equals((Rezervacija)listBox1.SelectedItem))
                {
                    if (!txtCena.Text.All(char.IsDigit))
                        MessageBox.Show("Cena mora biti broj!","Greska");
                    else if (dateOd.Value < DateTime.Today)
                        MessageBox.Show("Datum mora biti veci ili jednak od danasnjeg datuma", "Greska");
                    else if (dateDo.Value < dateOd.Value)
                        MessageBox.Show("Datm do mora biti veci ili jednak datumu od!", "Greska");                  
                    else
                    {
                        r.Cena = int.Parse(txtCena.Text);
                        r.DatumOd = dateOd.Value;
                        r.DatumDo = dateDo.Value;
                        Globalne.upisiRezervacije(rezervacije, Globalne.DatRezervacije);
                        listBox1.Items[listBox1.SelectedIndex] = r;
                        MessageBox.Show("Uspesno azuriranje rezervacije!");
                    }

                }
            }
        }
    }
}
