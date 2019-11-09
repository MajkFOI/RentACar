namespace RentACar
{
    partial class AdministratorForma
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
            this.UpravljanjeKorisnicimaGumb = new System.Windows.Forms.Button();
            this.UnosAutomobilaGumb = new System.Windows.Forms.Button();
            this.OdjavaGumb = new System.Windows.Forms.Button();
            this.PregledNajmovaGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpravljanjeKorisnicimaGumb
            // 
            this.UpravljanjeKorisnicimaGumb.Location = new System.Drawing.Point(78, 81);
            this.UpravljanjeKorisnicimaGumb.Name = "UpravljanjeKorisnicimaGumb";
            this.UpravljanjeKorisnicimaGumb.Size = new System.Drawing.Size(274, 54);
            this.UpravljanjeKorisnicimaGumb.TabIndex = 0;
            this.UpravljanjeKorisnicimaGumb.Text = "Upravljanje korisnicima";
            this.UpravljanjeKorisnicimaGumb.UseVisualStyleBackColor = true;
            this.UpravljanjeKorisnicimaGumb.Click += new System.EventHandler(this.UpravljanjeKorisnicimaGumb_Click);
            // 
            // UnosAutomobilaGumb
            // 
            this.UnosAutomobilaGumb.Location = new System.Drawing.Point(78, 151);
            this.UnosAutomobilaGumb.Name = "UnosAutomobilaGumb";
            this.UnosAutomobilaGumb.Size = new System.Drawing.Size(274, 52);
            this.UnosAutomobilaGumb.TabIndex = 2;
            this.UnosAutomobilaGumb.Text = "Unos automobila";
            this.UnosAutomobilaGumb.UseVisualStyleBackColor = true;
            this.UnosAutomobilaGumb.Click += new System.EventHandler(this.UnosAutomobilaGumb_Click);
            // 
            // OdjavaGumb
            // 
            this.OdjavaGumb.Location = new System.Drawing.Point(315, 12);
            this.OdjavaGumb.Name = "OdjavaGumb";
            this.OdjavaGumb.Size = new System.Drawing.Size(98, 31);
            this.OdjavaGumb.TabIndex = 16;
            this.OdjavaGumb.Text = "Odjavi se";
            this.OdjavaGumb.UseVisualStyleBackColor = true;
            this.OdjavaGumb.Click += new System.EventHandler(this.OdjavaGumb_Click);
            // 
            // PregledNajmovaGumb
            // 
            this.PregledNajmovaGumb.Location = new System.Drawing.Point(78, 219);
            this.PregledNajmovaGumb.Name = "PregledNajmovaGumb";
            this.PregledNajmovaGumb.Size = new System.Drawing.Size(274, 52);
            this.PregledNajmovaGumb.TabIndex = 17;
            this.PregledNajmovaGumb.Text = "Pregled najmova";
            this.PregledNajmovaGumb.UseVisualStyleBackColor = true;
            this.PregledNajmovaGumb.Click += new System.EventHandler(this.PregledNajmovaGumb_Click);
            // 
            // AdministratorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.PregledNajmovaGumb);
            this.Controls.Add(this.OdjavaGumb);
            this.Controls.Add(this.UnosAutomobilaGumb);
            this.Controls.Add(this.UpravljanjeKorisnicimaGumb);
            this.Name = "AdministratorForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForma_FormClosing);
            this.Load += new System.EventHandler(this.AdministratorForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AdministratorForma_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpravljanjeKorisnicimaGumb;
        private System.Windows.Forms.Button UnosAutomobilaGumb;
        private System.Windows.Forms.Button OdjavaGumb;
        private System.Windows.Forms.Button PregledNajmovaGumb;
    }
}