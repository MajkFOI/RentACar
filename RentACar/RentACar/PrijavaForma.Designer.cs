namespace RentACar
{
    partial class PrijavaForma
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
            this.KorisnickoImeUnos = new System.Windows.Forms.TextBox();
            this.LozinkaUnos = new System.Windows.Forms.TextBox();
            this.prijaviMeGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KorisnickoImeUnos
            // 
            this.KorisnickoImeUnos.Location = new System.Drawing.Point(149, 71);
            this.KorisnickoImeUnos.Name = "KorisnickoImeUnos";
            this.KorisnickoImeUnos.Size = new System.Drawing.Size(226, 20);
            this.KorisnickoImeUnos.TabIndex = 0;
            // 
            // LozinkaUnos
            // 
            this.LozinkaUnos.Location = new System.Drawing.Point(149, 119);
            this.LozinkaUnos.Name = "LozinkaUnos";
            this.LozinkaUnos.PasswordChar = '*';
            this.LozinkaUnos.Size = new System.Drawing.Size(226, 20);
            this.LozinkaUnos.TabIndex = 1;
            // 
            // prijaviMeGumb
            // 
            this.prijaviMeGumb.Location = new System.Drawing.Point(196, 158);
            this.prijaviMeGumb.Name = "prijaviMeGumb";
            this.prijaviMeGumb.Size = new System.Drawing.Size(134, 37);
            this.prijaviMeGumb.TabIndex = 2;
            this.prijaviMeGumb.Text = "Prijavi me";
            this.prijaviMeGumb.UseVisualStyleBackColor = true;
            this.prijaviMeGumb.Click += new System.EventHandler(this.PrijaviClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijaviMeGumb);
            this.Controls.Add(this.LozinkaUnos);
            this.Controls.Add(this.KorisnickoImeUnos);
            this.Name = "PrijavaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PrijavaForma_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KorisnickoImeUnos;
        private System.Windows.Forms.TextBox LozinkaUnos;
        private System.Windows.Forms.Button prijaviMeGumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}