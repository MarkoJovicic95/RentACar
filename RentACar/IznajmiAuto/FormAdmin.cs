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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
            if (Globalne.TrenutniAdmin.Equals(Globalne.GlavniAdmin))
            {                
                lblPrijavljen.Text += " (glavni admin)";
                
                Button btnDodajAdmina = new Button();
                btnDodajAdmina.Font = new Font("microsoft sans serif", 12);
                btnDodajAdmina.Text = "Dodaj administratora";
                btnDodajAdmina.Top = 60;
                btnDodajAdmina.Left = 20;
                btnDodajAdmina.Width = 200;
                btnDodajAdmina.Height = 40;
                Controls.Add(btnDodajAdmina);
                btnDodajAdmina.Click += new EventHandler(btnDodajAdmina_Click);
            }
        }
        private void btnDodajAdmina_Click(object sender, EventArgs e)
        {
            FormDodajKorisnika frm = new FormDodajKorisnika();
            Globalne.PraviAdmina = true;
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

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            Globalne.AdminPraviKupca = true;
            Globalne.PraviAdmina = false;
            FormDodajKorisnika frm = new FormDodajKorisnika();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Globalne.AzurirajKupca = true;
            FormAzuriraj frm = new FormAzuriraj();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnAzurirajAuto_Click(object sender, EventArgs e)
        {
            Globalne.AzurirajAuto = true;
            FormAzuriraj frm = new FormAzuriraj();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnUpisiAuto_Click(object sender, EventArgs e)
        {
            FormDodajAuto frm = new FormDodajAuto();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnAzurirajPonudu_Click(object sender, EventArgs e)
        {
            Globalne.AzurirajPonudu = true;
            FormAzuriraj frm = new FormAzuriraj();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnAzurirajRezervaciju_Click(object sender, EventArgs e)
        {
            FormAzurirajRezervacije frm = new FormAzurirajRezervacije();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnUpisRezervacija_Click(object sender, EventArgs e)
        {
            FormDodajRezervaciju frm = new FormDodajRezervaciju();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FormStatistika frm = new FormStatistika();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }
    }
}
