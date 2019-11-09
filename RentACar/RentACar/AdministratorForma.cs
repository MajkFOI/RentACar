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
    public partial class AdministratorForma : Form
    {
        public AdministratorForma(Korisnik korisnik)
        {
            InitializeComponent();
        }

        private void UnosAutomobilaGumb_Click(object sender, EventArgs e)
        {
            UnosAutomobilaForma forma = new UnosAutomobilaForma();
            forma.ShowDialog();
        }

        private void AdministratorForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pocetna = new PocetnaForma();
            pocetna.Show();
        }

        private void OdjavaGumb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministratorForma_Load(object sender, EventArgs e)
        {

        }

        private void UpravljanjeKorisnicimaGumb_Click(object sender, EventArgs e)
        {
            UpravljanjeKorisnicimaForma upravljanjeForma = new UpravljanjeKorisnicimaForma();
            upravljanjeForma.ShowDialog();
        }

        private void PregledNajmovaGumb_Click(object sender, EventArgs e)
        {
            NajmoviForma najamForma = new NajmoviForma();
            najamForma.ShowDialog();
        }

        private void AdministratorForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_9.html");
        }
    }
}
