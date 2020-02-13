namespace IznajmiAuto
{
    partial class FormStatistika
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblOdjaviSe = new System.Windows.Forms.LinkLabel();
            this.lblPrijavljen = new System.Windows.Forms.Label();
            this.btnCrtaj = new System.Windows.Forms.Button();
            this.dateMesec = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(745, 67);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(97, 35);
            this.btnNazad.TabIndex = 17;
            this.btnNazad.TabStop = false;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblOdjaviSe
            // 
            this.lblOdjaviSe.AutoSize = true;
            this.lblOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjaviSe.Location = new System.Drawing.Point(740, 13);
            this.lblOdjaviSe.Name = "lblOdjaviSe";
            this.lblOdjaviSe.Size = new System.Drawing.Size(102, 25);
            this.lblOdjaviSe.TabIndex = 18;
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
            this.lblPrijavljen.TabIndex = 16;
            this.lblPrijavljen.Text = "Prijavljeni ste kao administrator: ";
            // 
            // btnCrtaj
            // 
            this.btnCrtaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrtaj.Location = new System.Drawing.Point(388, 122);
            this.btnCrtaj.Name = "btnCrtaj";
            this.btnCrtaj.Size = new System.Drawing.Size(255, 49);
            this.btnCrtaj.TabIndex = 17;
            this.btnCrtaj.TabStop = false;
            this.btnCrtaj.Text = "Prikazi statistiku";
            this.btnCrtaj.UseVisualStyleBackColor = true;
            this.btnCrtaj.Click += new System.EventHandler(this.btnCrtaj_Click);
            // 
            // dateMesec
            // 
            this.dateMesec.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMesec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMesec.Location = new System.Drawing.Point(100, 145);
            this.dateMesec.Name = "dateMesec";
            this.dateMesec.ShowUpDown = true;
            this.dateMesec.Size = new System.Drawing.Size(218, 26);
            this.dateMesec.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Izaberite mesec:";
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dateMesec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCrtaj);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblOdjaviSe);
            this.Controls.Add(this.lblPrijavljen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatistika";
            this.Text = "FormStatistika";
            this.Load += new System.EventHandler(this.FormStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.LinkLabel lblOdjaviSe;
        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.Button btnCrtaj;
        private System.Windows.Forms.DateTimePicker dateMesec;
        private System.Windows.Forms.Label label10;
    }
}