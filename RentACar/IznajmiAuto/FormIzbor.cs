using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmiAuto
{
    public partial class FormIzbor : Form
    {
        public FormIzbor()
        {
            InitializeComponent();
        }
        
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if(Globalne.GlavniAdmin.Telefon == txtLoginTelefon.Text && Globalne.GlavniAdmin.Password==txtLoginPassword.Text)
            {
                Globalne.TrenutniAdmin = Globalne.GlavniAdmin;
                flag = 1;
                FormAdmin frm = new FormAdmin();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.Dock = DockStyle.Fill;
                Close();
            }
            if(flag == 0)
            {
                List<Administrator> listaAdmina = new List<Administrator>();
                listaAdmina = Globalne.procitajAdmine(Globalne.DatAdmin);
                if(!File.Exists(Globalne.DatAdmin))
                    MessageBox.Show("Ne postoji fajl sa adminima!");

                foreach (Administrator a in listaAdmina)
                {
                    if (a.Telefon == txtLoginTelefon.Text && a.Password == txtLoginPassword.Text)
                    {
                        Globalne.TrenutniAdmin = a;
                        flag = 1;
                        FormAdmin frm = new FormAdmin();
                        frm.MdiParent = this.ParentForm;
                        frm.Show();
                        frm.Dock = DockStyle.Fill;
                        Close();
                    }
                }
            }
            if(flag == 0 && File.Exists(Globalne.DatAdmin))
            {
                txtLoginTelefon.Text = "";
                txtLoginPassword.Text = "";
                txtLoginTelefon.Focus();
                MessageBox.Show("Telefon i lozinka se ne poklapaju","Login greska!");
            }

        }

        private void btnSignupKupac_Click(object sender, EventArgs e)
        {
            
            Globalne.PraviAdmina = false;
            Globalne.AdminPraviKupca = false;
            FormDodajKorisnika frm = new FormDodajKorisnika();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void brnLoginKupac_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Globalne.DatKupac))
                MessageBox.Show("Ne postoji fajl sa kupcima!");
            else
            {
                List<Kupac> kupci = new List<Kupac>();
                kupci = Globalne.procitajKupce(Globalne.DatKupac);
                int flag = 0;
                foreach (Kupac k in kupci)
                {
                    if (k.Telefon == txtLoginTelefon.Text && k.Password == txtLoginPassword.Text)
                    {
                        Globalne.TrenutniKupac = k;
                        flag = 1;
                        FormKupac frm = new FormKupac();
                        frm.MdiParent = this.ParentForm;
                        frm.Show();
                        frm.Dock = DockStyle.Fill;
                        Close();
                    }
                }
                if (flag == 0 && File.Exists(Globalne.DatAdmin))
                {
                    txtLoginTelefon.Text = "";
                    txtLoginPassword.Text = "";
                    txtLoginTelefon.Focus();
                    MessageBox.Show("Telefon i lozinka se ne poklapaju", "Login greska!");
                }
            }
        }
    }
}
