namespace RentACar
{
    partial class DodajKorisnikaForma
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
            this.TxtKorIme = new System.Windows.Forms.TextBox();
            this.TxtIme = new System.Windows.Forms.TextBox();
            this.TxtPrezime = new System.Windows.Forms.TextBox();
            this.TxtOIB = new System.Windows.Forms.TextBox();
            this.TxtVozacka = new System.Windows.Forms.TextBox();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.CmbUloga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtKorIme
            // 
            this.TxtKorIme.Location = new System.Drawing.Point(212, 141);
            this.TxtKorIme.Name = "TxtKorIme";
            this.TxtKorIme.Size = new System.Drawing.Size(170, 20);
            this.TxtKorIme.TabIndex = 0;
            // 
            // TxtIme
            // 
            this.TxtIme.Location = new System.Drawing.Point(212, 89);
            this.TxtIme.Name = "TxtIme";
            this.TxtIme.Size = new System.Drawing.Size(170, 20);
            this.TxtIme.TabIndex = 1;
            // 
            // TxtPrezime
            // 
            this.TxtPrezime.Location = new System.Drawing.Point(212, 115);
            this.TxtPrezime.Name = "TxtPrezime";
            this.TxtPrezime.Size = new System.Drawing.Size(170, 20);
            this.TxtPrezime.TabIndex = 2;
            // 
            // TxtOIB
            // 
            this.TxtOIB.Location = new System.Drawing.Point(212, 167);
            this.TxtOIB.Name = "TxtOIB";
            this.TxtOIB.Size = new System.Drawing.Size(170, 20);
            this.TxtOIB.TabIndex = 3;
            this.TxtOIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOIB_KeyPress);
            // 
            // TxtVozacka
            // 
            this.TxtVozacka.Location = new System.Drawing.Point(212, 193);
            this.TxtVozacka.Name = "TxtVozacka";
            this.TxtVozacka.Size = new System.Drawing.Size(170, 20);
            this.TxtVozacka.TabIndex = 4;
            this.TxtVozacka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVozacka_KeyPress);
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.Location = new System.Drawing.Point(212, 219);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.Size = new System.Drawing.Size(170, 20);
            this.TxtLozinka.TabIndex = 5;
            // 
            // CmbUloga
            // 
            this.CmbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUloga.FormattingEnabled = true;
            this.CmbUloga.Location = new System.Drawing.Point(212, 62);
            this.CmbUloga.Name = "CmbUloga";
            this.CmbUloga.Size = new System.Drawing.Size(170, 21);
            this.CmbUloga.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uloga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OIB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj vozače dozvole:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lozinka:";
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(212, 270);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(75, 23);
            this.BtnSpremi.TabIndex = 14;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(307, 270);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(75, 23);
            this.BtnOdustani.TabIndex = 15;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(212, 36);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(170, 20);
            this.TxtID.TabIndex = 16;
            // 
            // DodajKorisnikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 317);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbUloga);
            this.Controls.Add(this.TxtLozinka);
            this.Controls.Add(this.TxtVozacka);
            this.Controls.Add(this.TxtOIB);
            this.Controls.Add(this.TxtPrezime);
            this.Controls.Add(this.TxtIme);
            this.Controls.Add(this.TxtKorIme);
            this.Name = "DodajKorisnikaForma";
            this.Text = "DodajKorisnikaForma";
            this.Load += new System.EventHandler(this.DodajKorisnikaForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DodajKorisnikaForma_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKorIme;
        private System.Windows.Forms.TextBox TxtIme;
        private System.Windows.Forms.TextBox TxtPrezime;
        private System.Windows.Forms.TextBox TxtOIB;
        private System.Windows.Forms.TextBox TxtVozacka;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.ComboBox CmbUloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtID;
    }
}