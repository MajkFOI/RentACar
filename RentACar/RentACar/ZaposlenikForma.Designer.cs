namespace RentACar
{
    partial class ZaposlenikForma
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
            this.PregledNajmovaGumb = new System.Windows.Forms.Button();
            this.OdjavaGumb = new System.Windows.Forms.Button();
            this.PovratakServisGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PregledNajmovaGumb
            // 
            this.PregledNajmovaGumb.Location = new System.Drawing.Point(76, 80);
            this.PregledNajmovaGumb.Name = "PregledNajmovaGumb";
            this.PregledNajmovaGumb.Size = new System.Drawing.Size(286, 54);
            this.PregledNajmovaGumb.TabIndex = 0;
            this.PregledNajmovaGumb.Text = "Pregledaj najmove";
            this.PregledNajmovaGumb.UseVisualStyleBackColor = true;
            this.PregledNajmovaGumb.Click += new System.EventHandler(this.PregledNajmovaGumb_Click);
            // 
            // OdjavaGumb
            // 
            this.OdjavaGumb.Location = new System.Drawing.Point(320, 12);
            this.OdjavaGumb.Name = "OdjavaGumb";
            this.OdjavaGumb.Size = new System.Drawing.Size(98, 31);
            this.OdjavaGumb.TabIndex = 16;
            this.OdjavaGumb.Text = "Odjavi se";
            this.OdjavaGumb.UseVisualStyleBackColor = true;
            this.OdjavaGumb.Click += new System.EventHandler(this.OdjavaGumb_Click);
            // 
            // PovratakServisGumb
            // 
            this.PovratakServisGumb.Location = new System.Drawing.Point(76, 163);
            this.PovratakServisGumb.Name = "PovratakServisGumb";
            this.PovratakServisGumb.Size = new System.Drawing.Size(286, 55);
            this.PovratakServisGumb.TabIndex = 17;
            this.PovratakServisGumb.Text = "Evidentiraj povratak automobila sa servisa";
            this.PovratakServisGumb.UseVisualStyleBackColor = true;
            this.PovratakServisGumb.Click += new System.EventHandler(this.PovratakServisGumb_Click);
            // 
            // ZaposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.PovratakServisGumb);
            this.Controls.Add(this.OdjavaGumb);
            this.Controls.Add(this.PregledNajmovaGumb);
            this.Name = "ZaposlenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZaposlenikForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZaposlenikForma_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ZaposlenikForma_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PregledNajmovaGumb;
        private System.Windows.Forms.Button OdjavaGumb;
        private System.Windows.Forms.Button PovratakServisGumb;
    }
}