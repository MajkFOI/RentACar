namespace RentACar
{
    partial class ServisiForma
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
            this.PopisAutomobilaNaServisu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AutomobilPopravljenGumb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobilaNaServisu)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisAutomobilaNaServisu
            // 
            this.PopisAutomobilaNaServisu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisAutomobilaNaServisu.Location = new System.Drawing.Point(12, 33);
            this.PopisAutomobilaNaServisu.Name = "PopisAutomobilaNaServisu";
            this.PopisAutomobilaNaServisu.Size = new System.Drawing.Size(497, 129);
            this.PopisAutomobilaNaServisu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis automobila koji su na servisu:";
            // 
            // AutomobilPopravljenGumb
            // 
            this.AutomobilPopravljenGumb.Location = new System.Drawing.Point(12, 213);
            this.AutomobilPopravljenGumb.Name = "AutomobilPopravljenGumb";
            this.AutomobilPopravljenGumb.Size = new System.Drawing.Size(141, 33);
            this.AutomobilPopravljenGumb.TabIndex = 2;
            this.AutomobilPopravljenGumb.Text = "Automobil popravljen";
            this.AutomobilPopravljenGumb.UseVisualStyleBackColor = true;
            this.AutomobilPopravljenGumb.Click += new System.EventHandler(this.AutomobilPopravljenGumb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite automobil koji se vratio sa servisa da bi ga evidentirali kao ispravnog" +
    "";
            // 
            // ServisiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutomobilPopravljenGumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopisAutomobilaNaServisu);
            this.Name = "ServisiForma";
            this.Text = "ServisiForma";
            this.Load += new System.EventHandler(this.ServisiForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ServisiForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobilaNaServisu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisAutomobilaNaServisu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutomobilPopravljenGumb;
        private System.Windows.Forms.Label label2;
    }
}