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
    public partial class UpravljanjeKorisnicimaForma : Form
    {
        Evidencija evidencija;

        private void OsvjeziPodatke()
        {
            var korisnici = evidencija.DohvatiSveKorisnike();
            DgvKorisnici.DataSource = null;
            DgvKorisnici.DataSource = korisnici;
            DgvKorisnici.Columns[0].Width = 33;
        }

        public UpravljanjeKorisnicimaForma()
        {
            InitializeComponent();
            evidencija = new Evidencija();
        }

        private void DgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpravljanjeKorisnicimaForma_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            DodajKorisnikaForma formaDodaj = new DodajKorisnikaForma();
            formaDodaj.FormClosing += new FormClosingEventHandler(FormaDodajClosing);
            formaDodaj.ShowDialog();
        }

        private void FormaDodajClosing(object sender, FormClosingEventArgs e)
        {
            OsvjeziPodatke();
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            var uloga = DgvKorisnici.CurrentRow.Cells["Uloga"].Value.ToString();
            int idUloge = evidencija.PronadiUlogu(uloga);

            Korisnik korisnik = new Korisnik
            {
                id_korisnik = int.Parse(DgvKorisnici.CurrentRow.Cells["ID"].Value.ToString()),
                id_uloga = idUloge,
                ime = DgvKorisnici.CurrentRow.Cells["Ime"].Value.ToString(),
                prezime = DgvKorisnici.CurrentRow.Cells["Prezime"].Value.ToString(),
                korisnicko_ime = DgvKorisnici.CurrentRow.Cells["Korisnicko_ime"].Value.ToString(),
                oib = DgvKorisnici.CurrentRow.Cells["OIB"].Value.ToString(),
                broj_vozacke = DgvKorisnici.CurrentRow.Cells["Broj_vozacke"].Value.ToString(),
                lozinka = DgvKorisnici.CurrentRow.Cells["Lozinka"].Value.ToString()

            };
            DodajKorisnikaForma formaUredi = new DodajKorisnikaForma(korisnik);
            formaUredi.FormClosing += new FormClosingEventHandler(FormaUrediClosing);
            formaUredi.ShowDialog();
        }

        private void FormaUrediClosing(object sender, FormClosingEventArgs e)
        {
            OsvjeziPodatke();
        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            var uloga = DgvKorisnici.CurrentRow.Cells["Uloga"].Value.ToString();
            int idUloge = evidencija.PronadiUlogu(uloga);

            Korisnik korisnikZaIzbrisati = new Korisnik
            {
                id_korisnik = int.Parse(DgvKorisnici.CurrentRow.Cells["ID"].Value.ToString()),
                id_uloga = idUloge,
                ime = DgvKorisnici.CurrentRow.Cells["Ime"].Value.ToString(),
                prezime = DgvKorisnici.CurrentRow.Cells["Prezime"].Value.ToString(),
                korisnicko_ime = DgvKorisnici.CurrentRow.Cells["Korisnicko_ime"].Value.ToString(),
                oib = DgvKorisnici.CurrentRow.Cells["OIB"].Value.ToString(),
                broj_vozacke = DgvKorisnici.CurrentRow.Cells["Broj_vozacke"].Value.ToString(),
                lozinka = DgvKorisnici.CurrentRow.Cells["Lozinka"].Value.ToString()

            };

            evidencija.IzbrisiKorisnika(korisnikZaIzbrisati);
            OsvjeziPodatke();
        }

        private void Pretraga_TextChanged(object sender, EventArgs e)
        {
            string promjenjeniTekst = TxtPretraga.Text;
            var korisnici = evidencija.PronadiKorisnike(promjenjeniTekst);
            DgvKorisnici.DataSource = null;
            DgvKorisnici.DataSource = korisnici;
            DgvKorisnici.Columns[0].Width = 33;
        }

        private void UpravljanjeKorisnicimaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "Upravljanje_korisnicima.htm");
        }
    }
}
