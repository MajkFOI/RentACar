namespace RentACar
{
    partial class RacunForma
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NajamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AutomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RacunIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NajamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RacunIzvjestaj
            // 
            this.RacunIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NajamDs";
            reportDataSource1.Value = this.NajamBindingSource;
            reportDataSource2.Name = "AutomobilDs";
            reportDataSource2.Value = this.AutomobilBindingSource;
            reportDataSource3.Name = "MarkaDs";
            reportDataSource3.Value = this.MarkaBindingSource;
            reportDataSource4.Name = "ModelDs";
            reportDataSource4.Value = this.ModelBindingSource;
            this.RacunIzvjestaj.LocalReport.DataSources.Add(reportDataSource1);
            this.RacunIzvjestaj.LocalReport.DataSources.Add(reportDataSource2);
            this.RacunIzvjestaj.LocalReport.DataSources.Add(reportDataSource3);
            this.RacunIzvjestaj.LocalReport.DataSources.Add(reportDataSource4);
            this.RacunIzvjestaj.LocalReport.ReportEmbeddedResource = "RentACar.Racun.rdlc";
            this.RacunIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.RacunIzvjestaj.Name = "RacunIzvjestaj";
            this.RacunIzvjestaj.ServerReport.BearerToken = null;
            this.RacunIzvjestaj.Size = new System.Drawing.Size(596, 412);
            this.RacunIzvjestaj.TabIndex = 0;
            this.RacunIzvjestaj.Load += new System.EventHandler(this.RacunIzvjestaj_Load);
            this.RacunIzvjestaj.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.l);
            // 
            // RacunForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 412);
            this.Controls.Add(this.RacunIzvjestaj);
            this.Name = "RacunForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.RacunForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NajamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RacunIzvjestaj;
        private System.Windows.Forms.BindingSource NajamBindingSource;
        private System.Windows.Forms.BindingSource AutomobilBindingSource;
        private System.Windows.Forms.BindingSource MarkaBindingSource;
        private System.Windows.Forms.BindingSource ModelBindingSource;
    }
}