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
    public partial class FormDodajKorisnika : Form
    {
        public FormDodajKorisnika()
        {
            InitializeComponent();
        }

        private void FormDodajKorisnika_Load(object sender, EventArgs e)
        {
            if (Globalne.PraviAdmina)
            {
                lblPrijavljen.Text += " administrator: " + Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime + " (glavni admin)";
                label1.Text += " administratora";
                btnKreiraj.Text += " nalog administratora";
            }
            else if(Globalne.AdminPraviKupca){
                lblPrijavljen.Text += " administrator: " + Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
                label1.Text += " kupca";
                btnKreiraj.Text += " nalog kupca";
            }
            else
            {
                lblPrijavljen.Visible = false;
                lblOdjaviSe.Visible = false;
                label1.Text += " kupca";
                btnKreiraj.Text += " nalog kupca";
            }
            DateTime danas = DateTime.Today;
            int maxGodina = int.Parse(danas.Year.ToString()) - 18;
            string maxDatum = danas.Day + "/" + danas.Month + "/" + maxGodina.ToString();
            
            dateDatumRodjenja.Value = DateTime.Parse(maxDatum);
            dateDatumRodjenja.MaxDate = DateTime.Parse(maxDatum);
            
        }

        private void lblOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globalne.AdminPraviKupca = false;
            Globalne.PraviAdmina = false;
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            string pogresanUnos = "";
            int flag = 0;
            if(txtIme.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti ime!" + Environment.NewLine;
                flag = 1;
            }                
            if (txtPrezime.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti prezime!" + Environment.NewLine;
                flag = 1;
            }
            if (!txtJmbg.Text.All(char.IsDigit) || txtJmbg.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti ispravan JMBG!" + Environment.NewLine;
                flag = 1;
            }
            if (!txtTelefon.Text.All(char.IsDigit) || txtTelefon.Text.Trim() == "")
            {
                pogresanUnos += "Morate uneti ispravan telefon!" + Environment.NewLine;
                flag = 1;
            }
            if (Globalne.PraviAdmina)
            {
                List<Administrator> administrators = new List<Administrator>();
                administrators = Globalne.procitajAdmine(Globalne.DatAdmin);
                foreach (Administrator a in administrators)
                {
                    if (a.Telefon == txtTelefon.Text)
                    {
                        pogresanUnos += "Uneti telefon vec postoji!" + Environment.NewLine;
                        flag = 1;
                    }
                }
            }
            else
            {
                List<Kupac> kupci = new List<Kupac>();
                kupci = Globalne.procitajKupce(Globalne.DatKupac);
                foreach (Kupac k in kupci)
                {
                    if (k.Telefon == txtTelefon.Text)
                    {
                        pogresanUnos += "Uneti telefon vec postoji!" + Environment.NewLine;
                        flag = 1;
                    }
                }
            }
            if (txtLozinka.Text.Trim() == "")
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
                if (Globalne.PraviAdmina)
                {
                    Administrator noviAdmin = new Administrator(txtIme.Text, txtPrezime.Text, txtJmbg.Text, dateDatumRodjenja.Value, txtTelefon.Text, txtLozinka.Text);
                    noviAdmin.upisiAdmina(Globalne.DatAdmin);
                    MessageBox.Show(txtIme.Text + " " + txtPrezime.Text + " je uspesno dodat kao administrator!", "Uspesno dodat novi administrator");
                    Globalne.PraviAdmina = false;
                    FormAdmin frm = new FormAdmin();
                    frm.MdiParent = this.ParentForm;
                    frm.Show();
                    frm.Dock = DockStyle.Fill;
                    Close();
                }
                else
                {
                    Kupac noviKupac = new Kupac(txtIme.Text, txtPrezime.Text, txtJmbg.Text, dateDatumRodjenja.Value, txtTelefon.Text, txtLozinka.Text);
                    noviKupac.upisiKupca(Globalne.DatKupac);
                    MessageBox.Show("Nalog kupca " + txtIme.Text + " " + txtPrezime.Text + " je uspesno kreiran!", "Uspesno kreiran nalog");
                    if (Globalne.AdminPraviKupca)
                    {
                        Globalne.AdminPraviKupca = false;
                        FormAdmin frm = new FormAdmin();
                        frm.MdiParent = this.ParentForm;
                        frm.Show();
                        frm.Dock = DockStyle.Fill;
                        Close();
                    }
                    else
                    {
                        FormIzbor frm = new FormIzbor();
                        frm.MdiParent = this.ParentForm;
                        frm.Show();
                        frm.Dock = DockStyle.Fill;
                        Close();
                    }
                }
                    
                
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            if (Globalne.PraviAdmina || Globalne.AdminPraviKupca)
            {
                Globalne.PraviAdmina = false;
                Globalne.AdminPraviKupca = false;
                FormAdmin frm = new FormAdmin();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.Dock = DockStyle.Fill;
                Close();
            }
            else
            {
                FormIzbor frm = new FormIzbor();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.Dock = DockStyle.Fill;
                Close();
            }
        }
    }
}
