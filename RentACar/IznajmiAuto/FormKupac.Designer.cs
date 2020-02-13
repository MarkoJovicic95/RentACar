namespace IznajmiAuto
{
    partial class FormKupac
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblRezervacije = new System.Windows.Forms.Label();
            this.btnUkini = new System.Windows.Forms.Button();
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
            this.lblPrijavljen.Size = new System.Drawing.Size(257, 25);
            this.lblPrijavljen.TabIndex = 3;
            this.lblPrijavljen.Text = "Prijavljeni ste kao kupac: ";           
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(824, 144);
            this.listBox1.TabIndex = 16;
            // 
            // lblRezervacije
            // 
            this.lblRezervacije.AutoSize = true;
            this.lblRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacije.Location = new System.Drawing.Point(13, 102);
            this.lblRezervacije.Name = "lblRezervacije";
            this.lblRezervacije.Size = new System.Drawing.Size(263, 25);
            this.lblRezervacije.TabIndex = 17;
            this.lblRezervacije.Text = "Vase trenutne rezervacije:";
            // 
            // btnUkini
            // 
            this.btnUkini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkini.Location = new System.Drawing.Point(18, 289);
            this.btnUkini.Name = "btnUkini";
            this.btnUkini.Size = new System.Drawing.Size(824, 62);
            this.btnUkini.TabIndex = 18;
            this.btnUkini.TabStop = false;
            this.btnUkini.Text = "Ukini rezervaciju";
            this.btnUkini.UseVisualStyleBackColor = true;
            this.btnUkini.Click += new System.EventHandler(this.btnUkini_Click);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(18, 403);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(824, 62);
            this.btnRezervisi.TabIndex = 18;
            this.btnRezervisi.TabStop = false;
            this.btnRezervisi.Text = "Napravi novu rezervaciju";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // FormKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.btnUkini);
            this.Controls.Add(this.lblRezervacije);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblOdjaviSe);
            this.Controls.Add(this.lblPrijavljen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKupac";
            this.Text = "FormKupac";
            this.Load += new System.EventHandler(this.FormKupac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblOdjaviSe;
        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRezervacije;
        private System.Windows.Forms.Button btnUkini;
        private System.Windows.Forms.Button btnRezervisi;
    }
}