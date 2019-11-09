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
    public partial class NajmoviForma : Form
    {
        Evidencija evidncija;

        private void OsvjeziPodatke()
        {
            var najmovi = evidncija.DohvatiSveNajmove();
            DgvNajmovi.DataSource = null;
            DgvNajmovi.DataSource = najmovi;
            DgvNajmovi.Columns[1].Visible = false;
            DgvNajmovi.Columns[2].Visible = false;
            DgvNajmovi.Columns[0].Width = 35;
        }

        public NajmoviForma()
        {
            InitializeComponent();
            evidncija = new Evidencija();
        }

        private void NajmoviForma_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            Najam najamZaIzbrisat = DgvNajmovi.CurrentRow.DataBoundItem as Najam;
            int obrisan = evidncija.Obrisi(najamZaIzbrisat);
            if(obrisan != 0)
            {
                MessageBox.Show("Najam je obrisan!");
            }
            OsvjeziPodatke();
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            Najam najamZaIzmjenu = DgvNajmovi.CurrentRow.DataBoundItem as Najam;
            UrediNajamForma urediNajam = new UrediNajamForma(najamZaIzmjenu);
            urediNajam.FormClosing += new FormClosingEventHandler(FormaUrediClosing);
            urediNajam.ShowDialog();
        }

        private void FormaUrediClosing(object sender, FormClosingEventArgs e)
        {
            OsvjeziPodatke();
        }

        private void NajmoviForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_1.html");
        }
    }
}
