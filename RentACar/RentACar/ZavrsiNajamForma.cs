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
    public partial class ZavrsiNajamForma : Form
    {
        Najam trenutniNajam = null;
        Evidencija evidencija = null;
        public ZavrsiNajamForma(Najam najam)
        {
            InitializeComponent();
            trenutniNajam = najam;
            evidencija = new Evidencija();
        }

        private void ZavrsiNajamGumb_Click(object sender, EventArgs e)
        {
            evidencija.AzurirajZavrsenNajam(trenutniNajam, StanjeNakon.Text, VrijednostStete.Value);

            RacunForma racunForma = new RacunForma(trenutniNajam);
            racunForma.ShowDialog();
        }

        private void PosaljiNaServisGumb_Click(object sender, EventArgs e)
        {
            Automobil auto = evidencija.DohvatiAutomobilIzNajma(trenutniNajam);


            using (var db = new DBEntities())
            {
                db.Automobils.Attach(auto);
                auto.id_status = 2;
                db.SaveChanges();
            }

            MessageBox.Show("Automobil je uspješno poslan na servis");

        }

        private void ZavrsiNajamForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "Pregled_najmova.htm");
        }
    }
}
