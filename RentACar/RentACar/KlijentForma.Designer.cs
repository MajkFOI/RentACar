namespace RentACar
{
    partial class KlijentForma
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
            this.OdjavaGumb = new System.Windows.Forms.Button();
            this.DetaljiAutomobilaLabela = new System.Windows.Forms.Label();
            this.OdaberiteAutomobil = new System.Windows.Forms.Label();
            this.SlikaAutomobila = new System.Windows.Forms.PictureBox();
            this.PopisAutomobila = new System.Windows.Forms.DataGridView();
            this.PozdravnaPoruka = new System.Windows.Forms.Label();
            this.RezervirajGumb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaAutomobila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobila)).BeginInit();
            this.SuspendLayout();
            // 
            // OdjavaGumb
            // 
            this.OdjavaGumb.Location = new System.Drawing.Point(693, 12);
            this.OdjavaGumb.Name = "OdjavaGumb";
            this.OdjavaGumb.Size = new System.Drawing.Size(98, 31);
            this.OdjavaGumb.TabIndex = 15;
            this.OdjavaGumb.Text = "Odjavi se";
            this.OdjavaGumb.UseVisualStyleBackColor = true;
            this.OdjavaGumb.Click += new System.EventHandler(this.OdjavaGumb_Click);
            // 
            // DetaljiAutomobilaLabela
            // 
            this.DetaljiAutomobilaLabela.AutoSize = true;
            this.DetaljiAutomobilaLabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DetaljiAutomobilaLabela.Location = new System.Drawing.Point(586, 301);
            this.DetaljiAutomobilaLabela.Name = "DetaljiAutomobilaLabela";
            this.DetaljiAutomobilaLabela.Size = new System.Drawing.Size(0, 13);
            this.DetaljiAutomobilaLabela.TabIndex = 14;
            this.DetaljiAutomobilaLabela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OdaberiteAutomobil
            // 
            this.OdaberiteAutomobil.AutoSize = true;
            this.OdaberiteAutomobil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OdaberiteAutomobil.Location = new System.Drawing.Point(11, 83);
            this.OdaberiteAutomobil.Name = "OdaberiteAutomobil";
            this.OdaberiteAutomobil.Size = new System.Drawing.Size(101, 13);
            this.OdaberiteAutomobil.TabIndex = 12;
            this.OdaberiteAutomobil.Text = "Odaberite automobil";
            // 
            // SlikaAutomobila
            // 
            this.SlikaAutomobila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlikaAutomobila.Location = new System.Drawing.Point(509, 99);
            this.SlikaAutomobila.Name = "SlikaAutomobila";
            this.SlikaAutomobila.Size = new System.Drawing.Size(282, 199);
            this.SlikaAutomobila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlikaAutomobila.TabIndex = 11;
            this.SlikaAutomobila.TabStop = false;
            // 
            // PopisAutomobila
            // 
            this.PopisAutomobila.AllowUserToAddRows = false;
            this.PopisAutomobila.AllowUserToDeleteRows = false;
            this.PopisAutomobila.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PopisAutomobila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisAutomobila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopisAutomobila.Location = new System.Drawing.Point(10, 99);
            this.PopisAutomobila.MultiSelect = false;
            this.PopisAutomobila.Name = "PopisAutomobila";
            this.PopisAutomobila.ReadOnly = true;
            this.PopisAutomobila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PopisAutomobila.Size = new System.Drawing.Size(494, 330);
            this.PopisAutomobila.TabIndex = 10;
            this.PopisAutomobila.SelectionChanged += new System.EventHandler(this.PopisAutomobila_SelectionChanged);
            // 
            // PozdravnaPoruka
            // 
            this.PozdravnaPoruka.AutoSize = true;
            this.PozdravnaPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PozdravnaPoruka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PozdravnaPoruka.Location = new System.Drawing.Point(16, 19);
            this.PozdravnaPoruka.Name = "PozdravnaPoruka";
            this.PozdravnaPoruka.Size = new System.Drawing.Size(0, 16);
            this.PozdravnaPoruka.TabIndex = 16;
            // 
            // RezervirajGumb
            // 
            this.RezervirajGumb.Location = new System.Drawing.Point(576, 389);
            this.RezervirajGumb.Name = "RezervirajGumb";
            this.RezervirajGumb.Size = new System.Drawing.Size(155, 40);
            this.RezervirajGumb.TabIndex = 17;
            this.RezervirajGumb.Text = "Rezerviraj";
            this.RezervirajGumb.UseVisualStyleBackColor = true;
            this.RezervirajGumb.Click += new System.EventHandler(this.RezervirajGumb_Click);
            // 
            // KlijentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RezervirajGumb);
            this.Controls.Add(this.PozdravnaPoruka);
            this.Controls.Add(this.OdjavaGumb);
            this.Controls.Add(this.DetaljiAutomobilaLabela);
            this.Controls.Add(this.OdaberiteAutomobil);
            this.Controls.Add(this.SlikaAutomobila);
            this.Controls.Add(this.PopisAutomobila);
            this.Name = "KlijentForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorisnikForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KlijentForma_FormClosing);
            this.Load += new System.EventHandler(this.KlijentForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.KlijentForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.SlikaAutomobila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OdjavaGumb;
        private System.Windows.Forms.Label DetaljiAutomobilaLabela;
        private System.Windows.Forms.Label OdaberiteAutomobil;
        private System.Windows.Forms.PictureBox SlikaAutomobila;
        private System.Windows.Forms.DataGridView PopisAutomobila;
        private System.Windows.Forms.Label PozdravnaPoruka;
        private System.Windows.Forms.Button RezervirajGumb;
    }
}