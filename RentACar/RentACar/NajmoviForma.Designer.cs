namespace RentACar
{
    partial class NajmoviForma
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
            this.DgvNajmovi = new System.Windows.Forms.DataGridView();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNajmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvNajmovi
            // 
            this.DgvNajmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNajmovi.Location = new System.Drawing.Point(12, 12);
            this.DgvNajmovi.Name = "DgvNajmovi";
            this.DgvNajmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNajmovi.Size = new System.Drawing.Size(775, 217);
            this.DgvNajmovi.TabIndex = 0;
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(618, 254);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(75, 23);
            this.BtnUredi.TabIndex = 3;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.Location = new System.Drawing.Point(712, 254);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.BtnIzbrisi.TabIndex = 4;
            this.BtnIzbrisi.Text = "Izbriši";
            this.BtnIzbrisi.UseVisualStyleBackColor = true;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // NajmoviForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 289);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.DgvNajmovi);
            this.Name = "NajmoviForma";
            this.Text = "NajmoviForma";
            this.Load += new System.EventHandler(this.NajmoviForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NajmoviForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNajmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvNajmovi;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnIzbrisi;
    }
}