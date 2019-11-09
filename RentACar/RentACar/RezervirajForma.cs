using Podaci;
using System;
using PoslovnaLogika;
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
    public partial class RezervirajForma : Form
    {
        Evidencija evidencija;
        Automobil rezervacijaAutomobil = null;
        Korisnik rezerviraoKorisnik = null;
        public RezervirajForma(Automobil automobil, Korisnik korisnik)
        {
            InitializeComponent();
            rezervacijaAutomobil = automobil;
            rezerviraoKorisnik = korisnik;
            evidencija = new Evidencija();
        }

        private void RezervirajForma_Load(object sender, EventArgs e)
        {
            kalendarPocetkaRezervacije.BoldedDates = evidencija.DohvatiZauzeteDatume().ToArray();
            kalendarKrajaRezervacije.BoldedDates = evidencija.DohvatiZauzeteDatume().ToArray();
        }


        private void RezervirajGumb_Click(object sender, EventArgs e)
        {
            List<DateTime> ListaZauzetih = evidencija.DohvatiZauzeteDatume();
            bool OdabranZauzeti = false;
            double brojOdabranihDana = (kalendarKrajaRezervacije.SelectionStart - kalendarPocetkaRezervacije.SelectionStart).TotalDays;

            for (int i = 0; i <= brojOdabranihDana; i++)
            {
                foreach (var d in ListaZauzetih)
                {
                    if (kalendarPocetkaRezervacije.SelectionStart.AddDays(i).Date == d)
                    {
                        OdabranZauzeti = true;
                    }
                }
            }

            if (OdabranZauzeti == false)
            {
                Najam noviNajam = new Najam
                {
                    id_korisnik = rezerviraoKorisnik.id_korisnik,
                    id_automobil = rezervacijaAutomobil.id_automobil,
                    datum_najma = kalendarPocetkaRezervacije.SelectionStart,
                    datum_povrata = kalendarKrajaRezervacije.SelectionStart,
                    zavrsen = false
                };

                
                using (var db = new DBEntities())
                {
                    /*
                    var upit = from auto in db.Automobils
                               where auto.id_automobil == rezervacijaAutomobil.id_automobil
                               select auto.stanje;

                    List<string> stanje = upit.ToList();
                    noviNajam.stanje_prije_voznje = stanje.First();
                    */
                    db.Najams.Add(noviNajam);
                    db.SaveChanges();
                }
                

                MessageBox.Show("Uspješno ste rezervirali automobil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo Vas odaberite slobodan termin");
            }
        }

        private void RezervirajForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_6.html");
        }
    }
}
