using Podaci;
using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class RacunForma : Form
    {
        Najam trenutniNajam = null;
        Evidencija evidencija = null;

        public RacunForma(Najam najam)
        {
            InitializeComponent();
            trenutniNajam = najam;
            evidencija = new Evidencija();
        }

        private void RacunForma_Load(object sender, EventArgs e)
        {
            this.RacunIzvjestaj.RefreshReport();
        }

        private void RacunIzvjestaj_Load(object sender, EventArgs e)
        {
            NajamBindingSource.DataSource = trenutniNajam;

            Automobil automobil = evidencija.PronadiAutomobilZaNajam(trenutniNajam);

            AutomobilBindingSource.DataSource = automobil;
            ModelBindingSource.DataSource = automobil.Model;
            MarkaBindingSource.DataSource = automobil.Marka;

            this.RacunIzvjestaj.RefreshReport();
        }

        private void l(object sender, HelpEventArgs hlpevent)
        {

        }
    }
}
