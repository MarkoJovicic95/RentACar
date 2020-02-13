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
    public partial class FormRezervisi : Form
    {
        public FormRezervisi()
        {
            InitializeComponent();
        }
        List<Automobil> automobili;
        List<Ponuda> svePonude;
        
        Automobil auto;       
        bool uspesno;
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
            FormKupac frm = new FormKupac();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            Close();
        }

        private void FormRezervisi_Load(object sender, EventArgs e)
        {
            dateOd.Value = DateTime.Today;
            dateOd.MinDate = DateTime.Today;
            dateDo.Value = DateTime.Today;
            dateDo.MinDate = DateTime.Today;
            lblPrijavljen.Text += Globalne.TrenutniKupac.Ime + " " + Globalne.TrenutniKupac.Prezime;
            svePonude = Globalne.procitajPonude(Globalne.DatPonude);
            automobili = Globalne.procitajAutomobile(Globalne.DatAutomobili);
            foreach(Automobil a in automobili)                //pri pokretanju forme se popunjava combobox za marku 
                if(!cbMarka.Items.Contains(a.Marka))
                    cbMarka.Items.Add(a.Marka);
            
        }

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();           //brisanje svega iz combo boxova i reset selektovanih itema
            cbModel.ResetText();
            cbModel.SelectedIndex = -1;
            cbGodiste.ResetText();
            cbGodiste.Items.Clear();
            cbGodiste.SelectedIndex = -1;
            cbKubikaza.Items.Clear();
            cbKubikaza.ResetText();
            cbKubikaza.SelectedIndex = -1;
            cbKaroserija.Items.Clear();
            cbKaroserija.ResetText();
            cbKaroserija.SelectedIndex = -1;
            cbBrojVrata.Items.Clear();
            cbBrojVrata.ResetText();
            cbBrojVrata.SelectedIndex = -1;
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString())      //na odabir marke popunjava se model
                {
                    if (!cbModel.Items.Contains(a.Model))   
                        cbModel.Items.Add(a.Model);
                    auto = a;
                    br++;
                }
            if (br == 1)                  //ukoliko postoji samo jedan model automatski se selektuje
                cbModel.SelectedItem = cbModel.Items[0];
            
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGodiste.ResetText();
            cbGodiste.Items.Clear();
            cbGodiste.SelectedIndex = -1;
            cbKubikaza.Items.Clear();
            cbKubikaza.ResetText();
            cbKubikaza.SelectedIndex = -1;
            cbKaroserija.Items.Clear();
            cbKaroserija.ResetText();
            cbKaroserija.SelectedIndex = -1;
            cbBrojVrata.Items.Clear();
            cbBrojVrata.ResetText();
            cbBrojVrata.SelectedIndex = -1;
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;           
            foreach (Automobil a in automobili)    //na odabir modela popunjava se godiste  
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString())
                {
                    if (!cbGodiste.Items.Contains(a.Godiste))
                        cbGodiste.Items.Add(a.Godiste);
                    auto = a;
                    br++;
                }
            if (br == 1)        //ukoliko postoji samo jedno godiste automatski se selektuje
                cbGodiste.SelectedItem = cbGodiste.Items[0];
        }

        private void cbGodiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKubikaza.Items.Clear();
            cbKubikaza.ResetText();
            cbKubikaza.SelectedIndex = -1;
            cbKaroserija.Items.Clear();
            cbKaroserija.ResetText();
            cbKaroserija.SelectedIndex = -1;
            cbBrojVrata.Items.Clear();
            cbBrojVrata.ResetText();
            cbBrojVrata.SelectedIndex = -1;
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString()))
                {
                    if (!cbKubikaza.Items.Contains(a.Kubikaza))
                        cbKubikaza.Items.Add(a.Kubikaza);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbKubikaza.SelectedItem = cbKubikaza.Items[0];
        }

        private void cbKubikaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKaroserija.Items.Clear();
            cbKaroserija.ResetText();
            cbKaroserija.SelectedIndex = -1;
            cbBrojVrata.Items.Clear();
            cbBrojVrata.ResetText();
            cbBrojVrata.SelectedIndex = -1;
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString())
                    && a.Kubikaza == int.Parse(cbKubikaza.SelectedItem.ToString()))
                {
                    if (!cbKaroserija.Items.Contains(a.Karoserija))
                        cbKaroserija.Items.Add(a.Karoserija);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbKaroserija.SelectedItem = cbKaroserija.Items[0];
        }

        private void cbKaroserija_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBrojVrata.Items.Clear();
            cbBrojVrata.ResetText();
            cbBrojVrata.SelectedIndex = -1;
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString())
                    && a.Kubikaza == int.Parse(cbKubikaza.SelectedItem.ToString()) && a.Karoserija == cbKaroserija.SelectedItem.ToString())
                {
                    if (!cbBrojVrata.Items.Contains(a.BrojVrata))
                        cbBrojVrata.Items.Add(a.BrojVrata);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbBrojVrata.SelectedItem = cbBrojVrata.Items[0];

        }

        private void cbBrojVrata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGorivo.Items.Clear();
            cbGorivo.ResetText();
            cbGorivo.SelectedIndex = -1;
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString())
                    && a.Kubikaza == int.Parse(cbKubikaza.SelectedItem.ToString()) && a.Karoserija == cbKaroserija.SelectedItem.ToString() &&
                    a.BrojVrata == int.Parse(cbBrojVrata.SelectedItem.ToString()))
                {
                    if (!cbGorivo.Items.Contains(a.Gorivo))
                        cbGorivo.Items.Add(a.Gorivo);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbGorivo.SelectedItem = cbGorivo.Items[0];
        }

        private void cbGorivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPogon.Items.Clear();
            cbPogon.ResetText();
            cbPogon.SelectedIndex = -1;
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString())
                    && a.Kubikaza == int.Parse(cbKubikaza.SelectedItem.ToString()) && a.Karoserija == cbKaroserija.SelectedItem.ToString() &&
                    a.BrojVrata == int.Parse(cbBrojVrata.SelectedItem.ToString()) && a.Gorivo == cbGorivo.SelectedItem.ToString())
                {
                    if (!cbPogon.Items.Contains(a.Pogon))
                        cbPogon.Items.Add(a.Pogon);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbPogon.SelectedItem = cbPogon.Items[0];
        }

        private void cbPogon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMenjac.Items.Clear();
            cbMenjac.ResetText();
            cbMenjac.SelectedIndex = -1;
            int br = 0;
            foreach (Automobil a in automobili)
                if (a.Marka == cbMarka.SelectedItem.ToString() && a.Model == cbModel.SelectedItem.ToString() && a.Godiste == int.Parse(cbGodiste.SelectedItem.ToString())
                    && a.Kubikaza == int.Parse(cbKubikaza.SelectedItem.ToString()) && a.Karoserija == cbKaroserija.SelectedItem.ToString() &&
                    a.BrojVrata == int.Parse(cbBrojVrata.SelectedItem.ToString()) && a.Gorivo == cbGorivo.SelectedItem.ToString() && a.Pogon == cbPogon.SelectedItem.ToString())
                {
                    if (!cbMenjac.Items.Contains(a.Menjac))
                        cbMenjac.Items.Add(a.Menjac);
                    auto = a;
                    br++;
                }
            if (br == 1)
                cbMenjac.SelectedItem = cbMenjac.Items[0];
        }

        private void btnPonude_Click(object sender, EventArgs e)
        {
            if (cbMarka.Text == "" || cbModel.Text == "" || cbGodiste.Text == "" || cbKubikaza.Text == "" || cbKaroserija.Text == "" 
                || cbBrojVrata.Text == "" || cbGorivo.Text == "" || cbPogon.Text == "" || cbMenjac.Text == "")
                MessageBox.Show("Nisu izabrani svi podaci za automobil");
            else
            {
                foreach(Automobil a in automobili)
                {
                    if (cbMarka.Text == a.Marka && cbModel.Text == a.Model && int.Parse(cbGodiste.Text) == a.Godiste && int.Parse(cbKubikaza.Text) == a.Kubikaza 
                            && cbKaroserija.Text == a.Karoserija && int.Parse(cbBrojVrata.Text) == a.BrojVrata && cbGorivo.Text == a.Gorivo 
                            && cbPogon.Text == a.Pogon && cbMenjac.Text == a.Menjac)
                        auto = a;
                }
                listBox1.Items.Clear();                
                List<Ponuda> ponude;
                ponude = Globalne.procitajPonude(Globalne.DatPonude);
                foreach(Ponuda p in ponude)
                {
                    if (p.IdAuto == auto.Id)
                    {
                        listBox1.Items.Add(p);        //potrebna provera u slucaju da kupac samo klikne rezervisi za trenutni dan
                        if (dateOd.Value >= p.DatumOd && dateOd.Value <= p.DatumDo && dateDo.Value >= dateOd.Value && dateDo.Value <= p.DatumDo)
                        {
                            txtCena.Text = ((dateDo.Value - dateOd.Value).TotalDays * p.Cena + p.Cena).ToString(); 
                            uspesno = true;
                            listBox1.SelectedItem = p;
                        }
                    }
                }                         
            }            
        }
        
        private void btnRezervisi_Click(object sender, EventArgs e) 
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Morate izabrati neki od datume iz liste ponudjenih datuma!", "Greska");
            else if (uspesno)
            {
                uspesno = false;
                Rezervacija novaRezervacija = new Rezervacija(auto.Id, Globalne.TrenutniKupac.Id, dateOd.Value, dateDo.Value, int.Parse(txtCena.Text));
                novaRezervacija.upisiRezervaciju(Globalne.DatRezervacije);                
                Ponuda p1;
                Ponuda p2;
                Ponuda pom = (Ponuda)listBox1.SelectedItem;
                if (pom.DatumOd != dateOd.Value)
                {
                    p1 = new Ponuda(auto.Id, pom.DatumOd, dateOd.Value.AddDays(-1), pom.Cena);
                    svePonude.Add(p1);
                    listBox1.Items.Add(p1);
                }
                if (pom.DatumDo != dateDo.Value)    
                {
                    p2 = new Ponuda(auto.Id, dateDo.Value.AddDays(1), pom.DatumDo, pom.Cena);
                    svePonude.Add(p2);
                    listBox1.Items.Add(p2);
                }
                for (int i = svePonude.Count - 1; i >= 0; i--)
                {
                    if (svePonude[i].IdAuto == pom.IdAuto && svePonude[i].DatumOd == pom.DatumOd && svePonude[i].DatumDo == pom.DatumDo && svePonude[i].Cena == pom.Cena)
                    {
                        svePonude.RemoveAt(i);
                    }
                }
                Globalne.upisiPonude(svePonude, Globalne.DatPonude);               
                listBox1.Items.Remove(pom);
                MessageBox.Show("Uspesna rezervacija!", "Obavestenje");                
                FormKupac frm = new FormKupac();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.Dock = DockStyle.Fill;
                Close();
            }
            else
                MessageBox.Show("Izabrani datum nije medju ponudjenim!", "Pogresan unos");


        }

        private void dateDo_ValueChanged(object sender, EventArgs e)      
        {
            if (listBox1.SelectedIndex != -1)
            {
                Ponuda p = (Ponuda)listBox1.SelectedItem;
                if (dateOd.Value >= p.DatumOd && dateOd.Value <= p.DatumDo && dateDo.Value >= dateOd.Value && dateDo.Value <= p.DatumDo)
                {
                    txtCena.Text = ((dateDo.Value - dateOd.Value).TotalDays * p.Cena + p.Cena).ToString();
                    uspesno = true;
                }
                else
                {
                    uspesno = false;
                    txtCena.Text = "";
                }
            }


        }

        private void dateOd_ValueChanged(object sender, EventArgs e)         
        {
            if (listBox1.SelectedIndex != -1)
            {
                Ponuda p = (Ponuda)listBox1.SelectedItem;
                if (dateOd.Value >= p.DatumOd && dateOd.Value <= p.DatumDo && dateDo.Value >= dateOd.Value && dateDo.Value <= p.DatumDo)
                {
                    txtCena.Text = ((dateDo.Value - dateOd.Value).TotalDays * p.Cena + p.Cena).ToString();
                    uspesno = true;
                }
                else
                {
                    uspesno = false;
                    txtCena.Text = "";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Ponuda p = (Ponuda)listBox1.SelectedItem;
                if (dateOd.Value >= p.DatumOd && dateOd.Value <= p.DatumDo && dateDo.Value >= dateOd.Value && dateDo.Value <= p.DatumDo)
                {
                    txtCena.Text = ((dateDo.Value - dateOd.Value).TotalDays * p.Cena + p.Cena).ToString();
                    uspesno = true;
                }
                else
                {
                    uspesno = false;
                    txtCena.Text = "";
                }
            }
        }
    }
}
