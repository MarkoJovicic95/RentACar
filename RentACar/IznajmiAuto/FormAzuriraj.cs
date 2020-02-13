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
    public partial class FormAzuriraj : Form
    {
        public FormAzuriraj()
        {
            InitializeComponent();
        }
        List<Kupac> kupci;
        List<Automobil> automobili;
        List<Ponuda> ponude;
        List<Rezervacija> rezervacije;
        private void FormAzuriraj_Load(object sender, EventArgs e)
        {
            lblPrijavljen.Text += Globalne.TrenutniAdmin.Ime + " " + Globalne.TrenutniAdmin.Prezime;
            if (Globalne.AzurirajKupca)
            {
                panelAuto.Visible = false;
                panelAuto1.Visible = false;
                lblIzbor.Text += " kupca:";                
                kupci = Globalne.procitajKupce(Globalne.DatKupac);
                rezervacije = Globalne.procitajRezervacije(Globalne.DatRezervacije);
                foreach(Kupac k in kupci)
                {
                    listBox1.Items.Add(k);
                }
            }
            else if (Globalne.AzurirajAuto)
            {
                lbl1.Text = "Marka:";
                lbl2.Text = "Model:";
                lbl3.Text = "Godiste:";
                lbl4.Text = "Kubikaza:";
                lbl5.Text = "Pogon:";
                lblIzbor.Text += " automobil:";
                automobili = Globalne.procitajAutomobile(Globalne.DatAutomobili);
                ponude = Globalne.procitajPonude(Globalne.DatPonude);
                rezervacije = Globalne.procitajRezervacije(Globalne.DatRezervacije);
                foreach (Automobil a in automobili)
                {
                    listBox1.Items.Add(a);
                }

                dateOd.Value = DateTime.Today;
                dateOd.MinDate = DateTime.Today;
                dateDo.Value = DateTime.Today;
                dateDo.MinDate = DateTime.Today;
            }
            else if(Globalne.AzurirajPonudu)
            {
                comboBox1.Visible = true;
                lblIzbor.Text += " automobil:";
                automobili = Globalne.procitajAutomobile(Globalne.DatAutomobili);
                foreach (Automobil a in automobili)
                {
                    comboBox1.Items.Add(a);
                }
                ponude = Globalne.procitajPonude(Globalne.DatPonude);
                panelAuto.Visible = false;
                panelAuto1.Visible = false;
                lbl1.Text = "Cena po danu:";
                panelPonuda.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Globalne.AzurirajKupca)
            {
                Kupac k = (Kupac)listBox1.SelectedItem;
                if (k != null)
                {
                    txt1.Text = k.Ime;
                    txt2.Text = k.Prezime;
                    txt3.Text = k.Jmbg;
                    txt4.Text = k.Datum_rodjenja.ToShortDateString();
                    txt5.Text = k.Telefon;
                }
            }
            else if (Globalne.AzurirajAuto)
            {
                Automobil a = (Automobil)listBox1.SelectedItem;
                if (a != null)
                {
                    txt1.Text = a.Marka;
                    txt2.Text = a.Model;
                    txt3.Text = a.Godiste.ToString();
                    txt4.Text = a.Kubikaza.ToString();
                    txt5.Text = a.Pogon;
                    txt6.Text = a.Menjac;
                    txt7.Text = a.Karoserija;
                    txt8.Text = a.Gorivo;
                    txt9.Text = a.BrojVrata.ToString();           
                }
            }
            else if (Globalne.AzurirajPonudu)
            {
                Ponuda p = (Ponuda)listBox1.SelectedItem;
                if (p != null)
                {
                    txt1.Text = p.Cena.ToString();
                }
            }
        }

        private void lblOdjaviSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globalne.AzurirajAuto = false;
            Globalne.AzurirajKupca = false;
            Globalne.AzurirajPonudu = false;
            FormIzbor frm = new FormIzbor();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Globalne.AzurirajAuto = false;
            Globalne.AzurirajKupca = false;
            Globalne.AzurirajPonudu = false;
            FormAdmin frm = new FormAdmin();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nista nije selektovano u listi!", "Greska");
            else
            {
                if (Globalne.AzurirajKupca)               
                {
                    Kupac selektovan = (Kupac)listBox1.SelectedItem;
                    foreach (Rezervacija r in rezervacije.ToList())   //brisanje svih rezervacija gde se obrisani kupac pojavljuje 
                        if (r.IdKupac == selektovan.Id)
                            rezervacije.Remove(r);
                    Globalne.upisiRezervacije(rezervacije, Globalne.DatRezervacije);
                    kupci.Remove(selektovan);
                    Globalne.upisiKupce(kupci, Globalne.DatKupac);
                    txt1.Text = "";
                    txt2.Text = "";
                    txt3.Text = "";
                    txt4.Text = "";
                    txt5.Text = "";
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    
                    MessageBox.Show("Uspesno obrisan kupac");
                }
                else if (Globalne.AzurirajPonudu)
                {
                    ponude.Remove((Ponuda)listBox1.SelectedItem);
                    Globalne.upisiPonude(ponude, Globalne.DatPonude);
                    txt1.Text = "";
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("Uspesno obrisana ponuda");
                }
                else if (Globalne.AzurirajAuto)          
                {
                    Automobil selektovan = (Automobil)listBox1.SelectedItem;

                    foreach (Ponuda p in ponude.ToList())      //brisanje svih ponuda/rezervacija gde se taj automobil pojavljuje
                        if (p.IdAuto == selektovan.Id)
                            ponude.Remove(p);
                    foreach (Rezervacija r in rezervacije.ToList())
                        if (r.IdAuto == selektovan.Id)
                            rezervacije.Remove(r);

                    automobili.Remove(selektovan);       //brisanje selektovanog automobila
                    
                    
                    
                    MessageBox.Show("Uspesno obrisan automobil");
                    Globalne.upisiAutomobile(automobili, Globalne.DatAutomobili);
                    Globalne.upisiPonude(ponude, Globalne.DatPonude);
                    txt1.Text = "";
                    txt2.Text = "";
                    txt3.Text = "";
                    txt4.Text = "";
                    txt5.Text = "";
                    txt6.Text = "";
                    txt7.Text = "";
                    txt8.Text = "";
                    txt9.Text = "";
                    listBox1.Items.Remove(listBox1.SelectedItem);   
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nista nije selektovano u listi!", "Greska");
            else
            {
                if (Globalne.AzurirajKupca)
                {
                    foreach(Kupac k in kupci)
                        if (k.Equals((Kupac)listBox1.SelectedItem))
                        {
                            k.azuriraj(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text);
                            listBox1.Items[listBox1.SelectedIndex] = k;
                        }
                    Globalne.upisiKupce(kupci, Globalne.DatKupac);
                    MessageBox.Show("Uspesno azuriranje kupca");

                }
                else if (Globalne.AzurirajPonudu)
                {                   
                    foreach(Ponuda p in ponude)
                    {
                        if (p.Equals((Ponuda)listBox1.SelectedItem))
                        {
                            if (!txt1.Text.All(char.IsDigit))
                                MessageBox.Show("Cena mora biti broj");
                            else
                            {
                                p.Cena = int.Parse(txt1.Text);
                                Globalne.upisiPonude(ponude, Globalne.DatPonude);
                                listBox1.Items[listBox1.SelectedIndex] = p;
                                MessageBox.Show("Uspesno azuriranje ponude");
                            }     
                        }
                    }
                }
                else if (Globalne.AzurirajAuto)
                {
                    foreach (Automobil a in automobili)
                        if (a.Equals((Automobil)listBox1.SelectedItem))
                        {
                            a.azuriraj(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text, txt9.Text);
                            listBox1.Items[listBox1.SelectedIndex] = a;
                        }
                    Globalne.upisiAutomobile(automobili, Globalne.DatAutomobili);
                    MessageBox.Show("Uspesno azuriranje automobila");
                }
            }
        }

        private void btnPonuda_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Nista nije selektovano u listi!", "Greska");
            else
            {
                Automobil a = (Automobil)listBox1.SelectedItem;
                if ( txtCena.Text.Trim() == "" || !txtCena.Text.All(char.IsDigit))
                    MessageBox.Show("Morate uneti ispravno cenu!", "Greska");
                else if(dateDo.Value >= dateOd.Value)
                {
                    Ponuda novaPonuda = new Ponuda(a.Id, dateOd.Value, dateDo.Value, int.Parse(txtCena.Text));
                    novaPonuda.upisiPonudu(Globalne.DatPonude);
                    MessageBox.Show("Ponuda uspesno dodata!", "Uspesno dodavanje");
                }
                else
                {
                    MessageBox.Show("Datum do mora biti veci ili jednak datumu od!","Greska");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automobil auto = (Automobil)comboBox1.SelectedItem;
            listBox1.Items.Clear();
            foreach (Ponuda p in ponude)
            {
                if(p.IdAuto == auto.Id)
                {                    
                    listBox1.Items.Add(p);
                }
            }
        }
    }
}
