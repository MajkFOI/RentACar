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
    public partial class UnosAutomobilaForma : Form
    {
        Evidencija evidencija;

        public UnosAutomobilaForma()
        {
            InitializeComponent();
            GodisteUnos.Maximum = DateTime.Now.Year;
            evidencija = new Evidencija();
            PopisMarki.DataSource = evidencija.DohvatiMarke();
            PopisStatusa.DataSource = evidencija.DohvatiStatuse();
            PopisLokacija.DataSource = evidencija.DohvatiLokacije();

            Marka marka = PopisMarki.SelectedItem as Marka;
            PopisModela.DataSource = evidencija.DohvatiModele(marka);
        }

        private void OdabirSlike_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OdabirSlike.Image = Image.FromFile(ofd.FileName);
                SlikaLabela.Visible = false;
            }
        }

        private void SlikaLabela_Click(object sender, EventArgs e)
        {
            OdabirSlike_Click(sender, e);
        }

        private void PopisMarki_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopisModela.DataSource = null;
            Marka marka = PopisMarki.SelectedItem as Marka;
            PopisModela.DataSource = evidencija.DohvatiModele(marka);
        }

        private void UnesiAutomobilGumb_Click(object sender, EventArgs e)
        {
            Pretvorba pretvorba = new Pretvorba();
            byte[] slika = pretvorba.SlikaUBinarnu(OdabirSlike.Image);

            Automobil automobil = new Automobil();
            automobil.id_marka = (PopisMarki.SelectedItem as Marka).id_marka;
            automobil.id_model = (PopisModela.SelectedItem as Model).id_model;
            automobil.id_lokacija = (PopisLokacija.SelectedItem as Lokacija).id_lokacija;
            automobil.id_status = (PopisStatusa.SelectedItem as Status).id_status;
            automobil.tablica = TablicaUnos.Text;
            automobil.godiste = (int)GodisteUnos.Value;
            automobil.snaga = (int)SnagaUnos.Value;
            automobil.cijena_po_danu = CijenaPoDanuUnos.Value;
            automobil.slika = slika;

            bool ispravanUnos = evidencija.ProvjeriIspravnost(automobil);
            if (ispravanUnos)
            {
                int rezultat = evidencija.Spremi(automobil);
                if (rezultat > 0)
                {
                    MessageBox.Show("Automobil je uspješno dodan u bazu");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greška kod dodavanja u bazu.");
                }
            }
            else
            {
                string greske = evidencija.DohvatiGreske(automobil);
                MessageBox.Show("----------GREŠKE----------" + Environment.NewLine + greske);
            }   
        }

        private void UnosAutomobilaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "Unos_automobila.htm");
        }
    }
}
