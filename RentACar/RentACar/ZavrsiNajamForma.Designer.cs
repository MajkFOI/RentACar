namespace RentACar
{
    partial class ZavrsiNajamForma
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
            this.StanjeNakon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VrijednostStete = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ZavrsiNajamGumb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PosaljiNaServisGumb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VrijednostStete)).BeginInit();
            this.SuspendLayout();
            // 
            // StanjeNakon
            // 
            this.StanjeNakon.Location = new System.Drawing.Point(107, 62);
            this.StanjeNakon.Name = "StanjeNakon";
            this.StanjeNakon.Size = new System.Drawing.Size(276, 20);
            this.StanjeNakon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nastala šteta";
            // 
            // VrijednostStete
            // 
            this.VrijednostStete.DecimalPlaces = 2;
            this.VrijednostStete.Location = new System.Drawing.Point(107, 136);
            this.VrijednostStete.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VrijednostStete.Name = "VrijednostStete";
            this.VrijednostStete.Size = new System.Drawing.Size(275, 20);
            this.VrijednostStete.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrijednost nastale štete";
            // 
            // ZavrsiNajamGumb
            // 
            this.ZavrsiNajamGumb.Location = new System.Drawing.Point(107, 179);
            this.ZavrsiNajamGumb.Name = "ZavrsiNajamGumb";
            this.ZavrsiNajamGumb.Size = new System.Drawing.Size(153, 43);
            this.ZavrsiNajamGumb.TabIndex = 4;
            this.ZavrsiNajamGumb.Text = "Završi najam i kreiraj račun";
            this.ZavrsiNajamGumb.UseVisualStyleBackColor = true;
            this.ZavrsiNajamGumb.Click += new System.EventHandler(this.ZavrsiNajamGumb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ukoliko želite poslati automobil na servis zbog prevelike štete:";
            // 
            // PosaljiNaServisGumb
            // 
            this.PosaljiNaServisGumb.Location = new System.Drawing.Point(107, 277);
            this.PosaljiNaServisGumb.Name = "PosaljiNaServisGumb";
            this.PosaljiNaServisGumb.Size = new System.Drawing.Size(141, 34);
            this.PosaljiNaServisGumb.TabIndex = 6;
            this.PosaljiNaServisGumb.Text = "Pošalji na servis";
            this.PosaljiNaServisGumb.UseVisualStyleBackColor = true;
            this.PosaljiNaServisGumb.Click += new System.EventHandler(this.PosaljiNaServisGumb_Click);
            // 
            // ZavrsiNajamForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(507, 332);
            this.Controls.Add(this.PosaljiNaServisGumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZavrsiNajamGumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VrijednostStete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StanjeNakon);
            this.Name = "ZavrsiNajamForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZavrsiNajamForma";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ZavrsiNajamForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.VrijednostStete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StanjeNakon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown VrijednostStete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ZavrsiNajamGumb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PosaljiNaServisGumb;
    }
}