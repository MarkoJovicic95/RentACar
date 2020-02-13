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
    public partial class FormDodajAuto : Form
    {
        public FormDodajAuto()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormAdmin frm = new FormAdmin();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void lblOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void FormDodajAuto_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += " " + Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
        }

        private void btnDodajAuto_Click(object sender, EventArgs e)
        {
            string pogresanUnos = "";
            int flag = 0;
            if(txtMarka.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti marku automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (txtModel.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti model automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (txtGodiste.Text.Trim() == "" || !txtGodiste.Text.All(char.IsDigit) || int.Parse(txtGodiste.Text)>DateTime.Today.Year )
            {
                pogresanUnos += "Morate uneti korektno godiste automobila!" + Environment.NewLine;
                flag = 1;
            }
            if (txtKubikaza.Text.Trim() == "" || !txtKubikaza.Text.All(char.IsDigit))
            {
                pogresanUnos += "Morate uneti ispravno kubikazu!" + Environment.NewLine;
                flag = 1;
            }
            if (txtPogon.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti pogon!" + Environment.NewLine;
                flag = 1;
            }
            if (txtMenjac.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti vrstu menjaca!" + Environment.NewLine;
                flag = 1;
            }
            if (txtKaroserija.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti karoseriju!" + Environment.NewLine;
                flag = 1;
            }
            if (txtGorivo.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti vrstu goriva!" + Environment.NewLine;
                flag = 1;
            }
            if (txtBrojVrata.Text.Trim() == "" || !txtBrojVrata.Text.All(char.IsDigit))
            {
                pogresanUnos += "Morate uneti ispravno broj vrata!" + Environment.NewLine;
                flag = 1;
            }
            if(flag == 1)
            {
                MessageBox.Show(pogresanUnos, "Pogresan unos podataka!");
            }
            else
            {
                Automobil noviAuto = new Automobil(txtMarka.Text, txtModel.Text, int.Parse(txtGodiste.Text), int.Parse(txtKubikaza.Text), txtPogon.Text, txtMenjac.Text, txtKaroserija.Text, txtGorivo.Text, int.Parse(txtBrojVrata.Text));
                noviAuto.upisiAutomobil(Globalne.DatAutomobili);
                MessageBox.Show("Novi automobil uspesno dodat!", "Uspesno dodavanje");
                FormAdmin frm = new FormAdmin();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.Dock = DockStyle.Fill;
                Close();
                
            }
        }
    }
}
