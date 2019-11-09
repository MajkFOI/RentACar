namespace RentACar
{
    partial class UnosAutomobilaForma
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
            this.LokacijaLabela = new System.Windows.Forms.Label();
            this.PopisLokacija = new System.Windows.Forms.ComboBox();
            this.SnagaLabela = new System.Windows.Forms.Label();
            this.SnagaUnos = new System.Windows.Forms.NumericUpDown();
            this.GodisteLabela = new System.Windows.Forms.Label();
            this.GodisteUnos = new System.Windows.Forms.NumericUpDown();
            this.TablicaLabela = new System.Windows.Forms.Label();
            this.TablicaUnos = new System.Windows.Forms.TextBox();
            this.StatusLabela = new System.Windows.Forms.Label();
            this.PopisStatusa = new System.Windows.Forms.ComboBox();
            this.ModelLabela = new System.Windows.Forms.Label();
            this.PopisModela = new System.Windows.Forms.ComboBox();
            this.MarkaLabela = new System.Windows.Forms.Label();
            this.PopisMarki = new System.Windows.Forms.ComboBox();
            this.OdabirSlike = new System.Windows.Forms.PictureBox();
            this.UnesiAutomobilGumb = new System.Windows.Forms.Button();
            this.SlikaLabela = new System.Windows.Forms.Label();
            this.CijenaPoDanuUnos = new System.Windows.Forms.NumericUpDown();
            this.CijenaPoDanuLabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnagaUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GodisteUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdabirSlike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaPoDanuUnos)).BeginInit();
            this.SuspendLayout();
            // 
            // LokacijaLabela
            // 
            this.LokacijaLabela.AutoSize = true;
            this.LokacijaLabela.Location = new System.Drawing.Point(52, 148);
            this.LokacijaLabela.Name = "LokacijaLabela";
            this.LokacijaLabela.Size = new System.Drawing.Size(47, 13);
            this.LokacijaLabela.TabIndex = 41;
            this.LokacijaLabela.Text = "Lokacija";
            // 
            // PopisLokacija
            // 
            this.PopisLokacija.FormattingEnabled = true;
            this.PopisLokacija.Location = new System.Drawing.Point(52, 164);
            this.PopisLokacija.Name = "PopisLokacija";
            this.PopisLokacija.Size = new System.Drawing.Size(250, 21);
            this.PopisLokacija.TabIndex = 40;
            // 
            // SnagaLabela
            // 
            this.SnagaLabela.AutoSize = true;
            this.SnagaLabela.Location = new System.Drawing.Point(52, 279);
            this.SnagaLabela.Name = "SnagaLabela";
            this.SnagaLabela.Size = new System.Drawing.Size(67, 13);
            this.SnagaLabela.TabIndex = 39;
            this.SnagaLabela.Text = "Snaga(kWh)";
            // 
            // SnagaUnos
            // 
            this.SnagaUnos.Location = new System.Drawing.Point(52, 294);
            this.SnagaUnos.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SnagaUnos.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SnagaUnos.Name = "SnagaUnos";
            this.SnagaUnos.Size = new System.Drawing.Size(250, 20);
            this.SnagaUnos.TabIndex = 38;
            this.SnagaUnos.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // GodisteLabela
            // 
            this.GodisteLabela.AutoSize = true;
            this.GodisteLabela.Location = new System.Drawing.Point(52, 235);
            this.GodisteLabela.Name = "GodisteLabela";
            this.GodisteLabela.Size = new System.Drawing.Size(43, 13);
            this.GodisteLabela.TabIndex = 37;
            this.GodisteLabela.Text = "Godište";
            // 
            // GodisteUnos
            // 
            this.GodisteUnos.Location = new System.Drawing.Point(52, 251);
            this.GodisteUnos.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.GodisteUnos.Minimum = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            this.GodisteUnos.Name = "GodisteUnos";
            this.GodisteUnos.Size = new System.Drawing.Size(250, 20);
            this.GodisteUnos.TabIndex = 36;
            this.GodisteUnos.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            // 
            // TablicaLabela
            // 
            this.TablicaLabela.AutoSize = true;
            this.TablicaLabela.Location = new System.Drawing.Point(52, 192);
            this.TablicaLabela.Name = "TablicaLabela";
            this.TablicaLabela.Size = new System.Drawing.Size(42, 13);
            this.TablicaLabela.TabIndex = 35;
            this.TablicaLabela.Text = "Tablica";
            // 
            // TablicaUnos
            // 
            this.TablicaUnos.Location = new System.Drawing.Point(52, 208);
            this.TablicaUnos.Name = "TablicaUnos";
            this.TablicaUnos.Size = new System.Drawing.Size(250, 20);
            this.TablicaUnos.TabIndex = 34;
            // 
            // StatusLabela
            // 
            this.StatusLabela.AutoSize = true;
            this.StatusLabela.Location = new System.Drawing.Point(52, 105);
            this.StatusLabela.Name = "StatusLabela";
            this.StatusLabela.Size = new System.Drawing.Size(37, 13);
            this.StatusLabela.TabIndex = 33;
            this.StatusLabela.Text = "Status";
            // 
            // PopisStatusa
            // 
            this.PopisStatusa.FormattingEnabled = true;
            this.PopisStatusa.Location = new System.Drawing.Point(52, 120);
            this.PopisStatusa.Name = "PopisStatusa";
            this.PopisStatusa.Size = new System.Drawing.Size(250, 21);
            this.PopisStatusa.TabIndex = 32;
            // 
            // ModelLabela
            // 
            this.ModelLabela.AutoSize = true;
            this.ModelLabela.Location = new System.Drawing.Point(52, 60);
            this.ModelLabela.Name = "ModelLabela";
            this.ModelLabela.Size = new System.Drawing.Size(36, 13);
            this.ModelLabela.TabIndex = 31;
            this.ModelLabela.Text = "Model";
            // 
            // PopisModela
            // 
            this.PopisModela.FormattingEnabled = true;
            this.PopisModela.Location = new System.Drawing.Point(52, 76);
            this.PopisModela.Name = "PopisModela";
            this.PopisModela.Size = new System.Drawing.Size(250, 21);
            this.PopisModela.TabIndex = 30;
            // 
            // MarkaLabela
            // 
            this.MarkaLabela.AutoSize = true;
            this.MarkaLabela.Location = new System.Drawing.Point(52, 15);
            this.MarkaLabela.Name = "MarkaLabela";
            this.MarkaLabela.Size = new System.Drawing.Size(37, 13);
            this.MarkaLabela.TabIndex = 29;
            this.MarkaLabela.Text = "Marka";
            // 
            // PopisMarki
            // 
            this.PopisMarki.FormattingEnabled = true;
            this.PopisMarki.Location = new System.Drawing.Point(52, 32);
            this.PopisMarki.Name = "PopisMarki";
            this.PopisMarki.Size = new System.Drawing.Size(250, 21);
            this.PopisMarki.TabIndex = 28;
            this.PopisMarki.SelectedIndexChanged += new System.EventHandler(this.PopisMarki_SelectedIndexChanged);
            // 
            // OdabirSlike
            // 
            this.OdabirSlike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OdabirSlike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OdabirSlike.Location = new System.Drawing.Point(330, 32);
            this.OdabirSlike.Name = "OdabirSlike";
            this.OdabirSlike.Size = new System.Drawing.Size(430, 386);
            this.OdabirSlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OdabirSlike.TabIndex = 42;
            this.OdabirSlike.TabStop = false;
            this.OdabirSlike.Tag = "";
            this.OdabirSlike.Click += new System.EventHandler(this.OdabirSlike_Click);
            // 
            // UnesiAutomobilGumb
            // 
            this.UnesiAutomobilGumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnesiAutomobilGumb.Location = new System.Drawing.Point(52, 375);
            this.UnesiAutomobilGumb.Name = "UnesiAutomobilGumb";
            this.UnesiAutomobilGumb.Size = new System.Drawing.Size(250, 43);
            this.UnesiAutomobilGumb.TabIndex = 43;
            this.UnesiAutomobilGumb.Text = "Unesi automobil";
            this.UnesiAutomobilGumb.UseVisualStyleBackColor = true;
            this.UnesiAutomobilGumb.Click += new System.EventHandler(this.UnesiAutomobilGumb_Click);
            // 
            // SlikaLabela
            // 
            this.SlikaLabela.AutoSize = true;
            this.SlikaLabela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlikaLabela.Location = new System.Drawing.Point(481, 201);
            this.SlikaLabela.Name = "SlikaLabela";
            this.SlikaLabela.Size = new System.Drawing.Size(136, 13);
            this.SlikaLabela.TabIndex = 44;
            this.SlikaLabela.Text = "Kliknite da biste dodali sliku";
            this.SlikaLabela.Click += new System.EventHandler(this.SlikaLabela_Click);
            // 
            // CijenaPoDanuUnos
            // 
            this.CijenaPoDanuUnos.DecimalPlaces = 2;
            this.CijenaPoDanuUnos.Location = new System.Drawing.Point(52, 337);
            this.CijenaPoDanuUnos.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CijenaPoDanuUnos.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CijenaPoDanuUnos.Name = "CijenaPoDanuUnos";
            this.CijenaPoDanuUnos.Size = new System.Drawing.Size(250, 20);
            this.CijenaPoDanuUnos.TabIndex = 45;
            this.CijenaPoDanuUnos.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // CijenaPoDanuLabela
            // 
            this.CijenaPoDanuLabela.AutoSize = true;
            this.CijenaPoDanuLabela.Location = new System.Drawing.Point(52, 321);
            this.CijenaPoDanuLabela.Name = "CijenaPoDanuLabela";
            this.CijenaPoDanuLabela.Size = new System.Drawing.Size(78, 13);
            this.CijenaPoDanuLabela.TabIndex = 46;
            this.CijenaPoDanuLabela.Text = "Cijena po danu";
            // 
            // UnosAutomobilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CijenaPoDanuLabela);
            this.Controls.Add(this.CijenaPoDanuUnos);
            this.Controls.Add(this.SlikaLabela);
            this.Controls.Add(this.UnesiAutomobilGumb);
            this.Controls.Add(this.OdabirSlike);
            this.Controls.Add(this.LokacijaLabela);
            this.Controls.Add(this.PopisLokacija);
            this.Controls.Add(this.SnagaLabela);
            this.Controls.Add(this.SnagaUnos);
            this.Controls.Add(this.GodisteLabela);
            this.Controls.Add(this.GodisteUnos);
            this.Controls.Add(this.TablicaLabela);
            this.Controls.Add(this.TablicaUnos);
            this.Controls.Add(this.StatusLabela);
            this.Controls.Add(this.PopisStatusa);
            this.Controls.Add(this.ModelLabela);
            this.Controls.Add(this.PopisModela);
            this.Controls.Add(this.MarkaLabela);
            this.Controls.Add(this.PopisMarki);
            this.Name = "UnosAutomobilaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos automobila";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UnosAutomobilaForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.SnagaUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GodisteUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdabirSlike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CijenaPoDanuUnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LokacijaLabela;
        private System.Windows.Forms.ComboBox PopisLokacija;
        private System.Windows.Forms.Label SnagaLabela;
        private System.Windows.Forms.NumericUpDown SnagaUnos;
        private System.Windows.Forms.Label GodisteLabela;
        private System.Windows.Forms.NumericUpDown GodisteUnos;
        private System.Windows.Forms.Label TablicaLabela;
        private System.Windows.Forms.TextBox TablicaUnos;
        private System.Windows.Forms.Label StatusLabela;
        private System.Windows.Forms.ComboBox PopisStatusa;
        private System.Windows.Forms.Label ModelLabela;
        private System.Windows.Forms.ComboBox PopisModela;
        private System.Windows.Forms.Label MarkaLabela;
        private System.Windows.Forms.ComboBox PopisMarki;
        private System.Windows.Forms.Button UnesiAutomobilGumb;
        public System.Windows.Forms.PictureBox OdabirSlike;
        public System.Windows.Forms.Label SlikaLabela;
        private System.Windows.Forms.NumericUpDown CijenaPoDanuUnos;
        private System.Windows.Forms.Label CijenaPoDanuLabela;
    }
}