namespace RentACar
{
    partial class RezervirajForma
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
            this.kalendarPocetkaRezervacije = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.kalendarKrajaRezervacije = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RezervirajGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kalendarPocetkaRezervacije
            // 
            this.kalendarPocetkaRezervacije.Location = new System.Drawing.Point(29, 73);
            this.kalendarPocetkaRezervacije.MaxSelectionCount = 1;
            this.kalendarPocetkaRezervacije.Name = "kalendarPocetkaRezervacije";
            this.kalendarPocetkaRezervacije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Od kad želite rezervirati";
            // 
            // kalendarKrajaRezervacije
            // 
            this.kalendarKrajaRezervacije.Location = new System.Drawing.Point(352, 73);
            this.kalendarKrajaRezervacije.Name = "kalendarKrajaRezervacije";
            this.kalendarKrajaRezervacije.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(349, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do kad želite rezervirati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaci o automobilu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zauzeti datumi su boldani, molimo Vas odaberite slobodne datume";
            // 
            // RezervirajGumb
            // 
            this.RezervirajGumb.Location = new System.Drawing.Point(209, 272);
            this.RezervirajGumb.Name = "RezervirajGumb";
            this.RezervirajGumb.Size = new System.Drawing.Size(174, 44);
            this.RezervirajGumb.TabIndex = 6;
            this.RezervirajGumb.Text = "Rezerviraj";
            this.RezervirajGumb.UseVisualStyleBackColor = true;
            this.RezervirajGumb.Click += new System.EventHandler(this.RezervirajGumb_Click);
            // 
            // RezervirajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.RezervirajGumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kalendarKrajaRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kalendarPocetkaRezervacije);
            this.Name = "RezervirajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervirajForma";
            this.Load += new System.EventHandler(this.RezervirajForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.RezervirajForma_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar kalendarPocetkaRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar kalendarKrajaRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RezervirajGumb;
    }
}