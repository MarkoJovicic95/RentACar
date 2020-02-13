namespace IznajmiAuto
{
    partial class FormAdmin
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
            this.lblPrijavljen = new System.Windows.Forms.Label();
            this.lblOdjaviSe = new System.Windows.Forms.LinkLabel();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnUpisiAuto = new System.Windows.Forms.Button();
            this.btnAzurirajAuto = new System.Windows.Forms.Button();
            this.btnAzurirajPonudu = new System.Windows.Forms.Button();
            this.btnUpisRezervacija = new System.Windows.Forms.Button();
            this.btnAzurirajRezervaciju = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrijavljen
            // 
            this.lblPrijavljen.AutoSize = true;
            this.lblPrijavljen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljen.Location = new System.Drawing.Point(13, 13);
            this.lblPrijavljen.Name = "lblPrijavljen";
            this.lblPrijavljen.Size = new System.Drawing.Size(323, 25);
            this.lblPrijavljen.TabIndex = 0;
            this.lblPrijavljen.Text = "Prijavljeni ste kao administrator: ";
            // 
            // lblOdjaviSe
            // 
            this.lblOdjaviSe.AutoSize = true;
            this.lblOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjaviSe.Location = new System.Drawing.Point(740, 13);
            this.lblOdjaviSe.Name = "lblOdjaviSe";
            this.lblOdjaviSe.Size = new System.Drawing.Size(102, 25);
            this.lblOdjaviSe.TabIndex = 2;
            this.lblOdjaviSe.TabStop = true;
            this.lblOdjaviSe.Text = "Odjavi se";
            this.lblOdjaviSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOdjaviSe_LinkClicked);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpisi.Location = new System.Drawing.Point(79, 190);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(245, 40);
            this.btnUpisi.TabIndex = 3;
            this.btnUpisi.Text = "Dodaj novog kupca";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(360, 190);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(481, 40);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Azuriraj postojeceg kupca";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnUpisiAuto
            // 
            this.btnUpisiAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpisiAuto.Location = new System.Drawing.Point(79, 129);
            this.btnUpisiAuto.Name = "btnUpisiAuto";
            this.btnUpisiAuto.Size = new System.Drawing.Size(245, 40);
            this.btnUpisiAuto.TabIndex = 3;
            this.btnUpisiAuto.Text = "Dodaj novi automobil";
            this.btnUpisiAuto.UseVisualStyleBackColor = true;
            this.btnUpisiAuto.Click += new System.EventHandler(this.btnUpisiAuto_Click);
            // 
            // btnAzurirajAuto
            // 
            this.btnAzurirajAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajAuto.Location = new System.Drawing.Point(360, 129);
            this.btnAzurirajAuto.Name = "btnAzurirajAuto";
            this.btnAzurirajAuto.Size = new System.Drawing.Size(481, 40);
            this.btnAzurirajAuto.TabIndex = 3;
            this.btnAzurirajAuto.Text = "Azuriraj postojeci automobil";
            this.btnAzurirajAuto.UseVisualStyleBackColor = true;
            this.btnAzurirajAuto.Click += new System.EventHandler(this.btnAzurirajAuto_Click);
            // 
            // btnAzurirajPonudu
            // 
            this.btnAzurirajPonudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajPonudu.Location = new System.Drawing.Point(361, 252);
            this.btnAzurirajPonudu.Name = "btnAzurirajPonudu";
            this.btnAzurirajPonudu.Size = new System.Drawing.Size(481, 40);
            this.btnAzurirajPonudu.TabIndex = 3;
            this.btnAzurirajPonudu.Text = "Azuriraj ponude";
            this.btnAzurirajPonudu.UseVisualStyleBackColor = true;
            this.btnAzurirajPonudu.Click += new System.EventHandler(this.btnAzurirajPonudu_Click);
            // 
            // btnUpisRezervacija
            // 
            this.btnUpisRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpisRezervacija.Location = new System.Drawing.Point(79, 312);
            this.btnUpisRezervacija.Name = "btnUpisRezervacija";
            this.btnUpisRezervacija.Size = new System.Drawing.Size(245, 40);
            this.btnUpisRezervacija.TabIndex = 3;
            this.btnUpisRezervacija.Text = "Dodaj rezervaciju";
            this.btnUpisRezervacija.UseVisualStyleBackColor = true;
            this.btnUpisRezervacija.Click += new System.EventHandler(this.btnUpisRezervacija_Click);
            // 
            // btnAzurirajRezervaciju
            // 
            this.btnAzurirajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajRezervaciju.Location = new System.Drawing.Point(360, 312);
            this.btnAzurirajRezervaciju.Name = "btnAzurirajRezervaciju";
            this.btnAzurirajRezervaciju.Size = new System.Drawing.Size(481, 40);
            this.btnAzurirajRezervaciju.TabIndex = 3;
            this.btnAzurirajRezervaciju.Text = "Azuriraj rezervacije";
            this.btnAzurirajRezervaciju.UseVisualStyleBackColor = true;
            this.btnAzurirajRezervaciju.Click += new System.EventHandler(this.btnAzurirajRezervaciju_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj novu ponudu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAzurirajAuto_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(79, 378);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(762, 51);
            this.btnStatistika.TabIndex = 3;
            this.btnStatistika.Text = "Prikazi statistiku automobila";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnAzurirajRezervaciju);
            this.Controls.Add(this.btnAzurirajAuto);
            this.Controls.Add(this.btnAzurirajPonudu);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUpisRezervacija);
            this.Controls.Add(this.btnUpisiAuto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.lblOdjaviSe);
            this.Controls.Add(this.lblPrijavljen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.LinkLabel lblOdjaviSe;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnUpisiAuto;
        private System.Windows.Forms.Button btnAzurirajAuto;
        private System.Windows.Forms.Button btnAzurirajPonudu;
        private System.Windows.Forms.Button btnUpisRezervacija;
        private System.Windows.Forms.Button btnAzurirajRezervaciju;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStatistika;
    }
}