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
    public partial class PregledNajmovaForma : Form
    {
        Evidencija evidencija;
        public PregledNajmovaForma()
        {
            evidencija = new Evidencija();
            InitializeComponent();
        }

        private void PregledNajmovaForma_Load(object sender, EventArgs e)
        {
            PopisNajmova.DataSource = evidencija.DohvatiVazeceNajmove();
            PopisNajmova.Columns[0].Visible = false;
            PopisNajmova.Columns[1].Visible = false;
            PopisNajmova.Columns[2].Visible = false;
            PopisNajmova.Columns[3].HeaderText = "Datum najma";
            PopisNajmova.Columns[4].HeaderText = "Datum povrata";
            PopisNajmova.Columns[5].Visible = false;
            PopisNajmova.Columns[6].Visible = false;
            PopisNajmova.Columns[7].Visible = false;
        }

        private void UkloniNajamGumb_Click(object sender, EventArgs e)
        {
            Najam najam = PopisNajmova.CurrentRow.DataBoundItem as Najam;

            int rezultat = 0;

            rezultat = evidencija.Obrisi(najam);

            if(rezultat > 0)
            {
                MessageBox.Show("Najam uspješno uklonjen.");
            }
            else
            {
                MessageBox.Show("Greška kod brisanja najma.");
            }

            PopisNajmova.DataSource = evidencija.DohvatiVazeceNajmove();
        }

        private void ZavrsiNajamGumb_Click(object sender, EventArgs e)
        {
            Najam najam = PopisNajmova.CurrentRow.DataBoundItem as Najam;

            ZavrsiNajamForma zavrsiNajamForma = new ZavrsiNajamForma(najam);
            zavrsiNajamForma.ShowDialog();

            PopisNajmova.DataSource = evidencija.DohvatiVazeceNajmove();
        }

        private void PregledNajmovaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "Pregled_najmova.htm");
        }
    }
}
