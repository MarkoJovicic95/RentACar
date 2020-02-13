namespace IznajmiAuto
{
    partial class FormIzbor
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
            this.brnLoginKupac = new System.Windows.Forms.Button();
            this.btnSignupKupac = new System.Windows.Forms.Button();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.txtLoginTelefon = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnLoginKupac
            // 
            this.brnLoginKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnLoginKupac.Location = new System.Drawing.Point(267, 263);
            this.brnLoginKupac.Name = "brnLoginKupac";
            this.brnLoginKupac.Size = new System.Drawing.Size(377, 50);
            this.brnLoginKupac.TabIndex = 2;
            this.brnLoginKupac.Text = "Prijavi se kao kupac";
            this.brnLoginKupac.UseVisualStyleBackColor = true;
            this.brnLoginKupac.Click += new System.EventHandler(this.brnLoginKupac_Click);
            // 
            // btnSignupKupac
            // 
            this.btnSignupKupac.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignupKupac.FlatAppearance.BorderSize = 0;
            this.btnSignupKupac.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSignupKupac.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSignupKupac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignupKupac.Location = new System.Drawing.Point(267, 319);
            this.btnSignupKupac.Name = "btnSignupKupac";
            this.btnSignupKupac.Size = new System.Drawing.Size(377, 29);
            this.btnSignupKupac.TabIndex = 1;
            this.btnSignupKupac.TabStop = false;
            this.btnSignupKupac.Text = "Napravi novi nalog";
            this.btnSignupKupac.UseVisualStyleBackColor = true;
            this.btnSignupKupac.Click += new System.EventHandler(this.btnSignupKupac_Click);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(267, 422);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(377, 50);
            this.btnLoginAdmin.TabIndex = 3;
            this.btnLoginAdmin.Text = "Prijavi se kao administrator";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // txtLoginTelefon
            // 
            this.txtLoginTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginTelefon.Location = new System.Drawing.Point(401, 135);
            this.txtLoginTelefon.Name = "txtLoginTelefon";
            this.txtLoginTelefon.Size = new System.Drawing.Size(243, 31);
            this.txtLoginTelefon.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(401, 193);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(243, 31);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prijavljivanje";
            // 
            // FormIzbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignupKupac);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginTelefon);
            this.Controls.Add(this.brnLoginKupac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIzbor";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Izbor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnLoginKupac;
        private System.Windows.Forms.Button btnSignupKupac;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.TextBox txtLoginTelefon;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}