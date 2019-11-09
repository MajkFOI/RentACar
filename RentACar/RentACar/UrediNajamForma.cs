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
    public partial class UrediNajamForma : Form
    {
        Evidencija evidencija;
        Najam najamZaIzmjeniti;
        public UrediNajamForma(Najam najam)
        {
            InitializeComponent();
            evidencija = new Evidencija();
            najamZaIzmjeniti = najam;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            Automobil auto = (Automobil)CmbAutomobil.SelectedItem;
            Korisnik korisnik = (Korisnik)CmbKorisnik.SelectedItem;
            Najam izmjenjeniNajam = new Najam
            {
                id_najam = int.Parse(TxtId.Text),
                id_automobil =auto.id_automobil,
                id_korisnik = korisnik.id_korisnik,
                datum_najma = DtpNajam.Value,
                datum_povrata = DtpPovratak.Value,
                nastala_steta = TxtSteta.Text,
                iznos_štete = decimal.Parse(NudIznos.Value.ToString()),
                zavrsen = bool.Parse(CmbZavrsen.SelectedItem.ToString())
            };

            int rezultat = evidencija.AzurirajNajam(najamZaIzmjeniti, izmjenjeniNajam);
            if(rezultat == 0)
            {
                MessageBox.Show("Neuspješna promjena!");
            }
            this.Close();
        }

        private void UrediNajamForma_Load(object sender, EventArgs e)
        {
            CmbAutomobil.DataSource = null;
            CmbAutomobil.DataSource = evidencija.DohvatiAutomobile();
            CmbKorisnik.DataSource = null;
            CmbKorisnik.DataSource = evidencija.DohvatiKorisnikeCmb();
            TxtId.Text = najamZaIzmjeniti.id_najam.ToString();
            CmbAutomobil.SelectedIndex = CmbAutomobil.FindString(najamZaIzmjeniti.Automobil.ToString());
            CmbKorisnik.SelectedIndex = CmbKorisnik.FindString(najamZaIzmjeniti.Korisnik.ToString());
            DtpNajam.Value = najamZaIzmjeniti.datum_najma;
            DtpPovratak.Value = najamZaIzmjeniti.datum_povrata;
            TxtSteta.Text = najamZaIzmjeniti.nastala_steta;
            NudIznos.Value = decimal.Parse(najamZaIzmjeniti.iznos_štete.ToString());
            CmbZavrsen.SelectedIndex = CmbZavrsen.FindString(najamZaIzmjeniti.zavrsen.ToString());
            
        }

        private void UrediNajamForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_1.html");
        }
    }
}
