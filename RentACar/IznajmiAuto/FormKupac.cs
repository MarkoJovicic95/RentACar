using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmiAuto
{
    public partial class FormKupac : Form
    {
        public FormKupac()
        {
            InitializeComponent();
        }
        List<Rezervacija> rezervacije;
        private void lblOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void FormKupac_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += Globalne.TrenutniKupac.Ime + " " + Globalne.TrenutniKupac.Prezime;
            
            if (File.Exists(Globalne.DatRezervacije))
            {
                rezervacije = Globalne.procitajRezervacije(Globalne.DatRezervacije);
                foreach (Rezervacija r in rezervacije)
                    if (r.IdKupac == Globalne.TrenutniKupac.Id)
                    {
                        listBox1.Items.Add(r);
                    }
            }
        }

        private void btnUkini_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nista nije selektovano za brisanje!", "Greska");
            else
            {
                rezervacije.Remove((Rezervacija)listBox1.SelectedItem);
                Globalne.upisiRezervacije(rezervacije, Globalne.DatRezervacije);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            FormRezervisi frm = new FormRezervisi();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        
    }
}
