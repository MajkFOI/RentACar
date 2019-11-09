namespace RentACar
{
    partial class PocetnaForma
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
            this.PopisAutomobila = new System.Windows.Forms.DataGridView();
            this.SlikaAutomobila = new System.Windows.Forms.PictureBox();
            this.OdaberiteAutomobil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetaljiAutomobilaLabela = new System.Windows.Forms.Label();
            this.PrijavaGumb = new System.Windows.Forms.Button();
            this.BtnRegistriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaAutomobila)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisAutomobila
            // 
            this.PopisAutomobila.AllowUserToAddRows = false;
            this.PopisAutomobila.AllowUserToDeleteRows = false;
            this.PopisAutomobila.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PopisAutomobila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisAutomobila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopisAutomobila.Location = new System.Drawing.Point(9, 84);
            this.PopisAutomobila.MultiSelect = false;
            this.PopisAutomobila.Name = "PopisAutomobila";
            this.PopisAutomobila.ReadOnly = true;
            this.PopisAutomobila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PopisAutomobila.Size = new System.Drawing.Size(494, 330);
            this.PopisAutomobila.TabIndex = 2;
            this.PopisAutomobila.SelectionChanged += new System.EventHandler(this.PopisAutomobila_SelectionChanged);
            // 
            // SlikaAutomobila
            // 
            this.SlikaAutomobila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlikaAutomobila.Location = new System.Drawing.Point(508, 84);
            this.SlikaAutomobila.Name = "SlikaAutomobila";
            this.SlikaAutomobila.Size = new System.Drawing.Size(282, 199);
            this.SlikaAutomobila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlikaAutomobila.TabIndex = 3;
            this.SlikaAutomobila.TabStop = false;
            // 
            // OdaberiteAutomobil
            // 
            this.OdaberiteAutomobil.AutoSize = true;
            this.OdaberiteAutomobil.Location = new System.Drawing.Point(10, 68);
            this.OdaberiteAutomobil.Name = "OdaberiteAutomobil";
            this.OdaberiteAutomobil.Size = new System.Drawing.Size(101, 13);
            this.OdaberiteAutomobil.TabIndex = 4;
            this.OdaberiteAutomobil.Text = "Odaberite automobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morate se prijaviti da biste rezervirali automobil.";
            // 
            // DetaljiAutomobilaLabela
            // 
            this.DetaljiAutomobilaLabela.AutoSize = true;
            this.DetaljiAutomobilaLabela.Location = new System.Drawing.Point(585, 286);
            this.DetaljiAutomobilaLabela.Name = "DetaljiAutomobilaLabela";
            this.DetaljiAutomobilaLabela.Size = new System.Drawing.Size(0, 13);
            this.DetaljiAutomobilaLabela.TabIndex = 6;
            this.DetaljiAutomobilaLabela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrijavaGumb
            // 
            this.PrijavaGumb.Location = new System.Drawing.Point(554, 13);
            this.PrijavaGumb.Name = "PrijavaGumb";
            this.PrijavaGumb.Size = new System.Drawing.Size(114, 34);
            this.PrijavaGumb.TabIndex = 7;
            this.PrijavaGumb.Text = "Prijavi se";
            this.PrijavaGumb.UseVisualStyleBackColor = true;
            this.PrijavaGumb.Click += new System.EventHandler(this.PrijavaGumb_Click);
            // 
            // BtnRegistriraj
            // 
            this.BtnRegistriraj.Location = new System.Drawing.Point(674, 13);
            this.BtnRegistriraj.Name = "BtnRegistriraj";
            this.BtnRegistriraj.Size = new System.Drawing.Size(114, 34);
            this.BtnRegistriraj.TabIndex = 8;
            this.BtnRegistriraj.Text = "Registriraj se";
            this.BtnRegistriraj.UseVisualStyleBackColor = true;
            this.BtnRegistriraj.Click += new System.EventHandler(this.BtnRegistriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "F2 - podaci za prijavu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "F1 - pomoć u aplikaciji";
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegistriraj);
            this.Controls.Add(this.PrijavaGumb);
            this.Controls.Add(this.DetaljiAutomobilaLabela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OdaberiteAutomobil);
            this.Controls.Add(this.SlikaAutomobila);
            this.Controls.Add(this.PopisAutomobila);
            this.KeyPreview = true;
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pocetna_FormClosing);
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaForma_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PopisAutomobila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaAutomobila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PopisAutomobila;
        private System.Windows.Forms.PictureBox SlikaAutomobila;
        private System.Windows.Forms.Label OdaberiteAutomobil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetaljiAutomobilaLabela;
        private System.Windows.Forms.Button PrijavaGumb;
        private System.Windows.Forms.Button BtnRegistriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}