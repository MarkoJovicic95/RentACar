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
    public partial class FormDodajRezervaciju : Form
    {
        public FormDodajRezervaciju()
        {
            InitializeComponent();
        }
        List<Kupac> kupci;
        List<Automobil> automobili;
        private void FormDodajRezervaciju_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
            dateOd.Value = DateTime.Today;
            dateOd.MinDate = DateTime.Today;
            dateDo.Value = DateTime.Today;
            dateDo.MinDate = DateTime.Today;
            kupci = Globalne.procitajKupce(Globalne.DatKupac);
            foreach (Kupac k in kupci)
                cbKupac.Items.Add(k);
            automobili = Globalne.procitajAutomobile(Globalne.DatAutomobili);
            foreach (Automobil a in automobili)
                cbAuto.Items.Add(a);

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

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (cbKupac.SelectedIndex == -1 || cbAuto.SelectedIndex == -1)
                MessageBox.Show("Morate izabrati kupca i automobil!", "Greska");
            else
            {
                if (!txtCena.Text.All(char.IsDigit))
                    MessageBox.Show("Cena mora biti broj!", "Greska");
                else if (dateDo.Value < dateOd.Value)
                    MessageBox.Show("Datm do mora biti veci ili jednak datumu od!", "Gresla");
                else
                {
                    Kupac selektovanKupac = (Kupac)cbKupac.SelectedItem;
                    Automobil selektovanAuto = (Automobil)cbAuto.SelectedItem;
                    Rezervacija novaRezervacija = new Rezervacija(selektovanAuto.Id, selektovanKupac.Id, dateOd.Value, dateDo.Value, int.Parse(txtCena.Text));
                    novaRezervacija.upisiRezervaciju(Globalne.DatRezervacije);
                    MessageBox.Show("Uspesna rezervacija!", "Obavestenje");
                }
            }
        }
    }
}
