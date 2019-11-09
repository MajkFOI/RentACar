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
    public partial class RegistracijaForma : Form
    {
        Evidencija evidencija;

        public RegistracijaForma()
        {
            InitializeComponent();
            evidencija = new Evidencija();
        }

        private void RegistrirajClick(object sender, EventArgs e)
        {
            
        }

        private void RegistracijaForma_Load(object sender, EventArgs e)
        {

        }

        private void RegistrirajClick_Click(object sender, EventArgs e)
        {
            if (unosImena.Text == "" || unosPrezimena.Text == "" || unosOiba.Text == "" || unosKorisnickogImena.Text == "" || unosVozacke.Text == "" || unosLozinke.Text == "" || UnosPonovljeneLozinke.Text == "")
            {
                MessageBox.Show("Popunite sva polja", "Upozorenje!");
            }
            else if(unosLozinke.Text != UnosPonovljeneLozinke.Text)
            {
                MessageBox.Show("Nepodudaraju se lozinke", "Upozorenje!");
            }
            else if(evidencija.ProvjeriKorIme(unosKorisnickogImena.Text) != null)
            {
                MessageBox.Show("Korisničko ime zauzeto", "Upozorenje!");
            }
            else
            {
                Korisnik noviKorisnik = new Korisnik
                {
                    id_uloga = 2,
                    ime = unosImena.Text,
                    prezime = unosPrezimena.Text,
                    korisnicko_ime = unosKorisnickogImena.Text,
                    oib = unosOiba.Text,
                    broj_vozacke = unosVozacke.Text,
                    lozinka = unosLozinke.Text
                };
                evidencija.DodajKorisnika(noviKorisnik);
                MessageBox.Show("Uspješna registracija");
                this.Close();
            }
        }

        private void unosOiba_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void unosVozacke_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void RegistracijaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_4.html");
        }
    }
}
