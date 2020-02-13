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
    public partial class FormStatistika : Form
    {
        public FormStatistika()
        {
            InitializeComponent();
        }
        float stoPosto = 0;
        float xPosto = 0;
        float broj=0;
        DateTime pocetakMeseca;
        DateTime krajMeseca;
        List<Rezervacija> rezervacije;
        List<Ponuda> ponude;
        private void FormStatistika_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
            dateMesec.Format = DateTimePickerFormat.Custom;
            dateMesec.CustomFormat = "MMMM yyyy";
            dateMesec.ShowUpDown = true;
            rezervacije = Globalne.procitajRezervacije(Globalne.DatRezervacije);
            ponude = Globalne.procitajPonude(Globalne.DatPonude);
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
        
        public void crtaj(object sender, PaintEventArgs e)
        {
            
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(150, 300, 100, 100));
            e.Graphics.FillPie(Brushes.Blue, new Rectangle(150, 300, 100, 100), -90, broj);
        }
        private void btnCrtaj_Click(object sender, EventArgs e)      
        {
            Controls.Remove(Controls["lbl"]);
            Controls.Remove(Controls["txt"]);
            Controls.Remove(Controls["lbl2"]);
            Controls.Remove(Controls["txt2"]);
            xPosto = 0;
            stoPosto = 0;
            Label lbl = new Label();
            lbl.Name = "lbl";
            lbl.Top = 250;
            lbl.Left = 100;
            lbl.Width = 300;
            lbl.Font = new Font("microsoft sans serif", 12);            
            Controls.Add(lbl);

            Label lbl2 = new Label();
            lbl2.Name = "lbl2";
            lbl2.Top = 250;
            lbl2.Left = 500;
            lbl2.Width = 300;
            lbl2.Font = new Font("microsoft sans serif", 12);            
            Controls.Add(lbl2);

            TextBox txt2 = new TextBox();
            txt2.Name = "txt2";
            txt2.Top = 280;
            txt2.Left = 500;
            txt2.Width = 150;
            txt2.ReadOnly = true;
            txt2.Font = new Font("microsoft sans serif", 12);
            Controls.Add(txt2);

            TextBox txt = new TextBox();
            txt.Name = "txt";
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.Font = new Font("microsoft sans serif", 12);
            txt.Top = 420;
            txt.Left = 100;
            txt.Width = 300;
            txt.Height = 100;
            txt.Text = "Plava boja - zarada od rezervacija za izabrani mesec." + Environment.NewLine + "Crvena boja - mogucnost zarade od ponuda koje jos uvek nisu rezervisane";
            Controls.Add(txt);

            pocetakMeseca = DateTime.Parse("1/" + dateMesec.Value.Month + "/" + dateMesec.Value.Year);
            krajMeseca = DateTime.Parse(DateTime.DaysInMonth(dateMesec.Value.Year, dateMesec.Value.Month) + "/" + dateMesec.Value.Month + "/" + dateMesec.Value.Year);
            lbl2.Text = "Ukupna zarada za mesec " + pocetakMeseca.ToString("MMMM");
            
            foreach (Ponuda p in ponude)
            {
                if (p.DatumOd >= pocetakMeseca && p.DatumOd <= krajMeseca)
                {
                    if (p.DatumDo <= krajMeseca)
                        stoPosto += p.Cena * ((float)(p.DatumDo - p.DatumOd).TotalDays + 1);
                    else
                        stoPosto += p.Cena * ((float)(krajMeseca - p.DatumOd).TotalDays + 1);
                }
                else if (p.DatumDo >= pocetakMeseca && p.DatumDo <= krajMeseca)
                    stoPosto += p.Cena * ((float)(p.DatumDo - pocetakMeseca).TotalDays + 1);

            }
            foreach (Rezervacija r in rezervacije)
            {
                if (r.DatumOd >= pocetakMeseca && r.DatumOd <= krajMeseca)
                {
                    if (r.DatumDo <= krajMeseca)
                    {
                        stoPosto += r.Cena;
                        xPosto += r.Cena;
                    }
                    else
                    {
                        stoPosto += (r.Cena * ((float)(krajMeseca - r.DatumOd).TotalDays + 1)) / ((float)(r.DatumDo - r.DatumOd).TotalDays + 1);
                        xPosto += (r.Cena * ((float)(krajMeseca - r.DatumOd).TotalDays + 1)) / ((float)(r.DatumDo - r.DatumOd).TotalDays + 1);
                    }

                }
                else if (r.DatumDo >= pocetakMeseca && r.DatumDo <= krajMeseca)
                {
                    stoPosto += (r.Cena * ((float)(r.DatumDo - pocetakMeseca).TotalDays+1)) / ((float)(r.DatumDo - r.DatumOd).TotalDays + 1);
                    xPosto += (r.Cena * ((float)(r.DatumDo - pocetakMeseca).TotalDays + 1)) / ((float)(r.DatumDo - r.DatumOd).TotalDays + 1);
                }
            }
            txt2.Text = xPosto.ToString() + " dinara"; 
            if (xPosto == 0 && stoPosto == 0)
            {
                lbl.Text = "Procenat zarade: 0%";
                broj = 0f;
            }
            else
            {
                broj = (xPosto * 100f) / stoPosto;
                lbl.Text = "Procenat zarade: " + broj + "%";
            }
            broj *= 3.6f;
            Paint += crtaj;
            Invalidate(); 
            
        }
    }
}
