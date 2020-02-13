namespace IznajmiAuto
{
    partial class FormRezervisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOdjaviSe = new System.Windows.Forms.LinkLabel();
            this.lblPrijavljen = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGodiste = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKubikaza = new System.Windows.Forms.ComboBox();
            this.cbBrojVrata = new System.Windows.Forms.ComboBox();
            this.cbKaroserija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGorivo = new System.Windows.Forms.ComboBox();
            this.cbMenjac = new System.Windows.Forms.ComboBox();
            this.cbPogon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPonude = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOdjaviSe
            // 
            this.lblOdjaviSe.AutoSize = true;
            this.lblOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjaviSe.Location = new System.Drawing.Point(740, 13);
            this.lblOdjaviSe.Name = "lblOdjaviSe";
            this.lblOdjaviSe.Size = new System.Drawing.Size(102, 25);
            this.lblOdjaviSe.TabIndex = 66;
            this.lblOdjaviSe.TabStop = true;
            this.lblOdjaviSe.Text = "Odjavi se";
            this.lblOdjaviSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOdjaviSe_LinkClicked);
            // 
            // lblPrijavljen
            // 
            this.lblPrijavljen.AutoSize = true;
            this.lblPrijavljen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljen.Location = new System.Drawing.Point(13, 13);
            this.lblPrijavljen.Name = "lblPrijavljen";
            this.lblPrijavljen.Size = new System.Drawing.Size(257, 25);
            this.lblPrijavljen.TabIndex = 5;
            this.lblPrijavljen.Text = "Prijavljeni ste kao kupac: ";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(745, 67);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(97, 35);
            this.btnNazad.TabIndex = 66;
            this.btnNazad.TabStop = false;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // cbMarka
            // 
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(18, 74);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(188, 28);
            this.cbMarka.TabIndex = 1;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Odaberite marku:";
            // 
            // cbGodiste
            // 
            this.cbGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGodiste.FormattingEnabled = true;
            this.cbGodiste.Location = new System.Drawing.Point(18, 191);
            this.cbGodiste.Name = "cbGodiste";
            this.cbGodiste.Size = new System.Drawing.Size(188, 28);
            this.cbGodiste.TabIndex = 3;
            this.cbGodiste.SelectedIndexChanged += new System.EventHandler(this.cbGodiste_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Odaberite godiste:";
            // 
            // cbModel
            // 
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(18, 132);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(188, 28);
            this.cbModel.TabIndex = 2;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Odaberite model:";
            // 
            // cbKubikaza
            // 
            this.cbKubikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKubikaza.FormattingEnabled = true;
            this.cbKubikaza.Location = new System.Drawing.Point(236, 74);
            this.cbKubikaza.Name = "cbKubikaza";
            this.cbKubikaza.Size = new System.Drawing.Size(188, 28);
            this.cbKubikaza.TabIndex = 4;
            this.cbKubikaza.SelectedIndexChanged += new System.EventHandler(this.cbKubikaza_SelectedIndexChanged);
            // 
            // cbBrojVrata
            // 
            this.cbBrojVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrojVrata.FormattingEnabled = true;
            this.cbBrojVrata.Location = new System.Drawing.Point(236, 191);
            this.cbBrojVrata.Name = "cbBrojVrata";
            this.cbBrojVrata.Size = new System.Drawing.Size(188, 28);
            this.cbBrojVrata.TabIndex = 6;
            this.cbBrojVrata.SelectedIndexChanged += new System.EventHandler(this.cbBrojVrata_SelectedIndexChanged);
            // 
            // cbKaroserija
            // 
            this.cbKaroserija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKaroserija.FormattingEnabled = true;
            this.cbKaroserija.Location = new System.Drawing.Point(236, 132);
            this.cbKaroserija.Name = "cbKaroserija";
            this.cbKaroserija.Size = new System.Drawing.Size(188, 28);
            this.cbKaroserija.TabIndex = 5;
            this.cbKaroserija.SelectedIndexChanged += new System.EventHandler(this.cbKaroserija_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odaberite kubikazu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Odaberite broj vrata:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Odaberite karoseriju:";
            // 
            // cbGorivo
            // 
            this.cbGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGorivo.FormattingEnabled = true;
            this.cbGorivo.Location = new System.Drawing.Point(454, 74);
            this.cbGorivo.Name = "cbGorivo";
            this.cbGorivo.Size = new System.Drawing.Size(188, 28);
            this.cbGorivo.TabIndex = 7;
            this.cbGorivo.SelectedIndexChanged += new System.EventHandler(this.cbGorivo_SelectedIndexChanged);
            // 
            // cbMenjac
            // 
            this.cbMenjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenjac.FormattingEnabled = true;
            this.cbMenjac.Location = new System.Drawing.Point(454, 191);
            this.cbMenjac.Name = "cbMenjac";
            this.cbMenjac.Size = new System.Drawing.Size(188, 28);
            this.cbMenjac.TabIndex = 9;
            // 
            // cbPogon
            // 
            this.cbPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPogon.FormattingEnabled = true;
            this.cbPogon.Location = new System.Drawing.Point(454, 132);
            this.cbPogon.Name = "cbPogon";
            this.cbPogon.Size = new System.Drawing.Size(188, 28);
            this.cbPogon.TabIndex = 8;
            this.cbPogon.SelectedIndexChanged += new System.EventHandler(this.cbPogon_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Odaberite gorivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Odaberite menjac:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Odaberite pogon:";
            // 
            // btnPonude
            // 
            this.btnPonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonude.Location = new System.Drawing.Point(18, 226);
            this.btnPonude.Name = "btnPonude";
            this.btnPonude.Size = new System.Drawing.Size(624, 51);
            this.btnPonude.TabIndex = 10;
            this.btnPonude.Text = "Prikazi dostupne termine odabranog automobila";
            this.btnPonude.UseVisualStyleBackColor = true;
            this.btnPonude.Click += new System.EventHandler(this.btnPonude_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 124);
            this.listBox1.TabIndex = 66;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateOd
            // 
            this.dateOd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOd.Location = new System.Drawing.Point(18, 449);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(258, 26);
            this.dateOd.TabIndex = 18;
            this.dateOd.ValueChanged += new System.EventHandler(this.dateOd_ValueChanged);
            // 
            // dateDo
            // 
            this.dateDo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDo.Location = new System.Drawing.Point(18, 508);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(258, 26);
            this.dateDo.TabIndex = 18;
            this.dateDo.ValueChanged += new System.EventHandler(this.dateDo_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Odaberite datum preuzimanja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Odaberite datum vracanja:";
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(329, 449);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(183, 26);
            this.txtCena.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ukupna cena rezervacije:";
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(329, 485);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(313, 51);
            this.btnRezervisi.TabIndex = 16;
            this.btnRezervisi.Text = "Rezervisi automobil";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // FormRezervisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.dateDo);
            this.Controls.Add(this.dateOd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.btnPonude);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPogon);
            this.Controls.Add(this.cbKaroserija);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMenjac);
            this.Controls.Add(this.cbBrojVrata);
            this.Controls.Add(this.cbGodiste);
            this.Controls.Add(this.cbGorivo);
            this.Controls.Add(this.cbKubikaza);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblOdjaviSe);
            this.Controls.Add(this.lblPrijavljen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezervisi";
            this.Text = "FormRezervisi";
            this.Load += new System.EventHandler(this.FormRezervisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblOdjaviSe;
        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGodiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKubikaza;
        private System.Windows.Forms.ComboBox cbBrojVrata;
        private System.Windows.Forms.ComboBox cbKaroserija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGorivo;
        private System.Windows.Forms.ComboBox cbMenjac;
        private System.Windows.Forms.ComboBox cbPogon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPonude;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.DateTimePicker dateDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRezervisi;
    }
}