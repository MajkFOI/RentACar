namespace RentACar
{
    partial class PregledNajmovaForma
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
            this.PopisNajmova = new System.Windows.Forms.DataGridView();
            this.UkloniNajamGumb = new System.Windows.Forms.Button();
            this.ZavrsiNajamGumb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopisNajmova)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisNajmova
            // 
            this.PopisNajmova.AllowUserToAddRows = false;
            this.PopisNajmova.AllowUserToDeleteRows = false;
            this.PopisNajmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisNajmova.Location = new System.Drawing.Point(28, 12);
            this.PopisNajmova.Name = "PopisNajmova";
            this.PopisNajmova.ReadOnly = true;
            this.PopisNajmova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PopisNajmova.Size = new System.Drawing.Size(444, 267);
            this.PopisNajmova.TabIndex = 0;
            // 
            // UkloniNajamGumb
            // 
            this.UkloniNajamGumb.Location = new System.Drawing.Point(302, 285);
            this.UkloniNajamGumb.Name = "UkloniNajamGumb";
            this.UkloniNajamGumb.Size = new System.Drawing.Size(124, 40);
            this.UkloniNajamGumb.TabIndex = 1;
            this.UkloniNajamGumb.Text = "Ukloni najam";
            this.UkloniNajamGumb.UseVisualStyleBackColor = true;
            this.UkloniNajamGumb.Click += new System.EventHandler(this.UkloniNajamGumb_Click);
            // 
            // ZavrsiNajamGumb
            // 
            this.ZavrsiNajamGumb.Location = new System.Drawing.Point(79, 285);
            this.ZavrsiNajamGumb.Name = "ZavrsiNajamGumb";
            this.ZavrsiNajamGumb.Size = new System.Drawing.Size(124, 40);
            this.ZavrsiNajamGumb.TabIndex = 2;
            this.ZavrsiNajamGumb.Text = "Završi najam";
            this.ZavrsiNajamGumb.UseVisualStyleBackColor = true;
            this.ZavrsiNajamGumb.Click += new System.EventHandler(this.ZavrsiNajamGumb_Click);
            // 
            // PregledNajmovaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(502, 339);
            this.Controls.Add(this.ZavrsiNajamGumb);
            this.Controls.Add(this.UkloniNajamGumb);
            this.Controls.Add(this.PopisNajmova);
            this.Name = "PregledNajmovaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled najmova";
            this.Load += new System.EventHandler(this.PregledNajmovaForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PregledNajmovaForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.PopisNajmova)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisNajmova;
        private System.Windows.Forms.Button UkloniNajamGumb;
        private System.Windows.Forms.Button ZavrsiNajamGumb;
    }
}