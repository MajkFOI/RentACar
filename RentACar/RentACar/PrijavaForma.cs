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
    public partial class PrijavaForma : Form
    {

        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void PrijaviClick(object sender, EventArgs e)
        {
            Evidencija evidencija = new Evidencija();
            Korisnik korisnik = evidencija.PronadiKorisnika(KorisnickoImeUnos.Text, LozinkaUnos.Text);

            if (korisnik != null)
            {
                if (korisnik.id_uloga == 1)
                {
                    AdministratorForma administratorForma = new AdministratorForma(korisnik);
                    administratorForma.Show();
                    this.Close();
                }
                else if(korisnik.id_uloga == 2)
                {
                    KlijentForma klijentForma = new KlijentForma(korisnik);
                    klijentForma.Show();
                    this.Close();
                }
                else if (korisnik.id_uloga == 3)
                {
                    ZaposlenikForma zaposlenikForma = new ZaposlenikForma(korisnik);
                    zaposlenikForma.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime i/ili lozinka");
            }
            
        }

        private void PrijavaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_3.html");
        }
    }
}
