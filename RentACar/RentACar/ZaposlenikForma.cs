using Podaci;
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
    public partial class ZaposlenikForma : Form
    {
        public ZaposlenikForma(Korisnik korisnik)
        {
            InitializeComponent();
        }

        private void ZaposlenikForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pocetna = new PocetnaForma();
            pocetna.Show();
        }

        private void OdjavaGumb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledNajmovaGumb_Click(object sender, EventArgs e)
        {
            PregledNajmovaForma pregledNajmovaForma = new PregledNajmovaForma();
            pregledNajmovaForma.ShowDialog();
        }

        private void PovratakServisGumb_Click(object sender, EventArgs e)
        {
            ServisiForma servisiForma = new ServisiForma();
            servisiForma.ShowDialog();
        }

        private void ZaposlenikForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_8.html");
        }
    }
}
