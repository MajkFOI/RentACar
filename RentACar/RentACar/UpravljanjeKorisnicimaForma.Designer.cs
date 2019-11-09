namespace RentACar
{
    partial class UpravljanjeKorisnicimaForma
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
            this.DgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvKorisnici
            // 
            this.DgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKorisnici.Location = new System.Drawing.Point(12, 34);
            this.DgvKorisnici.Name = "DgvKorisnici";
            this.DgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvKorisnici.Size = new System.Drawing.Size(776, 208);
            this.DgvKorisnici.TabIndex = 0;
            this.DgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKorisnici_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnici:";
            // 
            // TxtPretraga
            // 
            this.TxtPretraga.Location = new System.Drawing.Point(74, 259);
            this.TxtPretraga.Name = "TxtPretraga";
            this.TxtPretraga.Size = new System.Drawing.Size(123, 20);
            this.TxtPretraga.TabIndex = 2;
            this.TxtPretraga.TextChanged += new System.EventHandler(this.Pretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pretraga:";
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(506, 257);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(76, 23);
            this.BtnDodaj.TabIndex = 4;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(611, 257);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(75, 23);
            this.BtnUredi.TabIndex = 5;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Location = new System.Drawing.Point(713, 257);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.BtnIzbrisi.TabIndex = 6;
            this.BtnIzbrisi.Text = "Izbriši";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // UpravljanjeKorisnicimaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvKorisnici);
            this.Name = "UpravljanjeKorisnicimaForma";
            this.Text = "UpravljanjeKorisnicimaForma";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnicimaForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UpravljanjeKorisnicimaForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnIzbrisi;
    }
}