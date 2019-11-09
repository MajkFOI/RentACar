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
    public partial class DodajKorisnikaForma : Form
    {
        Evidencija evidencija;
        private Korisnik korisnikZaIzmjenu;

        public DodajKorisnikaForma()
        {
            InitializeComponent();
            evidencija = new Evidencija();
        }

        public DodajKorisnikaForma(Korisnik korisnik)
        {
            InitializeComponent();
            evidencija = new Evidencija();
            korisnikZaIzmjenu = korisnik;

        }

        private void DodajKorisnikaForma_Load(object sender, EventArgs e)
        {
            var uloge = evidencija.DohvatiUloge();
            CmbUloga.DataSource = null;
            CmbUloga.DataSource = uloge;

            if(korisnikZaIzmjenu != null)
            {
                CmbUloga.SelectedIndex = korisnikZaIzmjenu.id_uloga - 1;
                TxtID.Text = korisnikZaIzmjenu.id_korisnik.ToString();
                TxtIme.Text = korisnikZaIzmjenu.ime;
                TxtPrezime.Text = korisnikZaIzmjenu.prezime;
                TxtKorIme.Text = korisnikZaIzmjenu.korisnicko_ime;
                TxtOIB.Text = korisnikZaIzmjenu.oib;
                TxtVozacka.Text = korisnikZaIzmjenu.broj_vozacke;
                TxtLozinka.Text = korisnikZaIzmjenu.lozinka;
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            if(korisnikZaIzmjenu == null) // Dodaje se novi korisnik
            {
                Korisnik korisnik = new Korisnik
                {
                    id_uloga = CmbUloga.SelectedIndex + 1,
                    ime = TxtIme.Text,
                    prezime = TxtPrezime.Text,
                    oib = TxtOIB.Text,
                    broj_vozacke = TxtVozacka.Text,
                    korisnicko_ime = TxtKorIme.Text,
                    lozinka = TxtLozinka.Text
                };
                evidencija.DodajKorisnika(korisnik);
            }
            else //Mjenja se postojeci korisnik
            {
                Korisnik izmjenjeniKorisnik = new Korisnik
                {
                    id_uloga = CmbUloga.SelectedIndex + 1,
                    ime = TxtIme.Text,
                    prezime = TxtPrezime.Text,
                    oib = TxtOIB.Text,
                    broj_vozacke = TxtVozacka.Text,
                    korisnicko_ime = TxtKorIme.Text,
                    lozinka = TxtLozinka.Text
                };
                evidencija.AzurirajKorisnika(korisnikZaIzmjenu, izmjenjeniKorisnik);
            } 
            this.Close();
        }

        private void TxtOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtVozacka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void DodajKorisnikaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "Upravljanje_korisnicima.htm");
            
        }
    }
}
