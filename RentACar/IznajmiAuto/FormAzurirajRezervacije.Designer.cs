namespace IznajmiAuto
{
    partial class FormAzurirajRezervacije
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
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.lblIzbor = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblOdjaviSe
            // 
            this.lblOdjaviSe.AutoSize = true;
            this.lblOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjaviSe.Location = new System.Drawing.Point(740, 13);
            this.lblOdjaviSe.Name = "lblOdjaviSe";
            this.lblOdjaviSe.Size = new System.Drawing.Size(102, 25);
            this.lblOdjaviSe.TabIndex = 4;
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
            this.lblPrijavljen.Size = new System.Drawing.Size(323, 25);
            this.lblPrijavljen.TabIndex = 3;
            this.lblPrijavljen.Text = "Prijavljeni ste kao administrator: ";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(745, 67);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(97, 35);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.TabStop = false;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // cbKupac
            // 
            this.cbKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(19, 138);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(734, 28);
            this.cbKupac.TabIndex = 21;
            this.cbKupac.SelectedIndexChanged += new System.EventHandler(this.cbKupac_SelectedIndexChanged);
            // 
            // lblIzbor
            // 
            this.lblIzbor.AutoSize = true;
            this.lblIzbor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbor.Location = new System.Drawing.Point(14, 110);
            this.lblIzbor.Name = "lblIzbor";
            this.lblIzbor.Size = new System.Drawing.Size(146, 25);
            this.lblIzbor.TabIndex = 19;
            this.lblIzbor.Text = "Izaberi kupca:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(735, 144);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(402, 428);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(351, 42);
            this.btnAzuriraj.TabIndex = 22;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(19, 428);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(351, 42);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.TabStop = false;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(560, 370);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(193, 26);
            this.txtCena.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Datum do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Datum od:";
            // 
            // dateOd
            // 
            this.dateOd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOd.Location = new System.Drawing.Point(18, 370);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(193, 26);
            this.dateOd.TabIndex = 25;
            this.dateOd.Value = new System.DateTime(2001, 1, 1, 12, 56, 0, 0);
            // 
            // dateDo
            // 
            this.dateDo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDo.Location = new System.Drawing.Point(286, 368);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(193, 26);
            this.dateDo.TabIndex = 24;
            this.dateDo.Value = new System.DateTime(2001, 1, 1, 12, 56, 0, 0);
            // 
            // FormAzurirajRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOd);
            this.Controls.Add(this.dateDo);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.lblIzbor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblOdjaviSe);
            this.Controls.Add(this.lblPrijavljen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAzurirajRezervacije";
            this.Text = "FormAzurirajRezervacije";
            this.Load += new System.EventHandler(this.FormAzurirajRezervacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblOdjaviSe;
        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.Label lblIzbor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.DateTimePicker dateDo;
    }
}