using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Podaci;

namespace PoslovnaLogika
{
    public class Evidencija
    {
        #region PronadiKorisnika
        /// <summary>
        ///  Pronalazak korisnika kod prijave.
        /// </summary>
        /// <param name="korisnickoIme"> Koristi se za pronalazak korisničkog imena </param> 
        /// <param name="lozinka"> Koristi se za provjeru lozinke </param> 
        public Korisnik PronadiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik = null;

            using (var db = new DBEntities())
            {
                korisnik = (from k
                            in db.Korisniks
                            where k.korisnicko_ime == korisnickoIme &
                            k.lozinka == lozinka
                            select k).FirstOrDefault();
            }
            return korisnik;
        }
        #endregion

        #region DohvatiAutomobile
        /// <summary>
        ///  Dohvaća sve automobile koji trenutno nisu na servisu.
        /// </summary>
        public List<Automobil> DohvatiAutomobile()
        {
            List<Automobil> automobili = new List<Automobil>();

            using (var db = new DBEntities())
            {
                automobili = (from a
                              in db.Automobils.Include("Lokacija").Include("Status").Include("Marka").Include("Model")
                              where a.id_status != 2
                              select a
                              ).ToList();
            }

            foreach (var item in automobili)
            {
                item.Status = DohvatiTrenutniStatus(item);
            }

            return automobili;
        }
        #endregion

        #region DohvatiTrenutniStatus
        /// <summary>
        ///  Dohvaća trenutni statusa automobila s obzirom na trenutni datum i sve najmove.
        /// </summary>
        /// <param name="automobil"> Automobil za koji se traži status. </param>
        /// <returns> Vraća dohvaćeni objekt statusa automobila </returns>
        public Status DohvatiTrenutniStatus(Automobil automobil)
        {
            DateTime trenutniDatum = DateTime.Today;
            List<Najam> najmovi = new List<Najam>();

            using (var db = new DBEntities())
            {
                najmovi = (from n in db.Najams where n.id_automobil == automobil.id_automobil select n).ToList();
            }

            // Ako je automobil trenutno rezerviran i rezervacija nije završena, vrati objekt statusa "Rezervirano"
            foreach (var najam in najmovi)
            {
                if (trenutniDatum >= najam.datum_najma && trenutniDatum <= najam.datum_povrata && najam.zavrsen == false)
                    return DohvatiStatuse().Where(status => status.id_status == 3).FirstOrDefault();// 3 - Rezervirano (status)
            }

            // Inače, vrati status "Dostupan"
            return DohvatiStatuse().Where(status => status.id_status == 1).FirstOrDefault(); ; // 1 - Dostupno (status)
        }
        #endregion

        #region DohvatiMarke
        /// <summary>
        ///  Dohvaća sve marke automobila.
        /// </summary>
        public List<Marka> DohvatiMarke()
        {
            List<Marka> marke = new List<Marka>();

            using (var db = new DBEntities())
            {
                marke = db.Markas.ToList();
            }

            return marke;
        }
        #endregion

        #region DohvatiModele
        /// <summary>
        ///  Dohvaća sve modele automobila.
        /// </summary>
        /// <param name="marka"> Marka automobila čije modele dohvaćamo. </param>
        public List<Model> DohvatiModele(Marka marka)
        {
            List<Model> modeli = new List<Model>();

            using (var db = new DBEntities())
            {
                modeli = (from m in db.Models where m.id_marka == marka.id_marka select m).ToList();
            }

            return modeli;
        }
        #endregion

        #region DohvatiStatuse
        /// <summary>
        ///  Dohvaća sve statuse automobila.
        /// </summary>
        public List<Status> DohvatiStatuse()
        {
            List<Status> statusi = new List<Status>();

            using (var db = new DBEntities())
            {
                statusi = db.Status.ToList();
            }

            return statusi;
        }
        #endregion

        #region DohvatiLokacije
        /// <summary>
        ///  Dohvaća sve lokacije automobila.
        /// </summary>
        public List<Lokacija> DohvatiLokacije()
        {
            List<Lokacija> lokacije = new List<Lokacija>();

            using (var db = new DBEntities())
            {
                lokacije = db.Lokacijas.ToList();
            }

            return lokacije;
        }
        #endregion

        #region DohvatiVazeceNajmove
        /// <summary>
        ///  Dohvaća sve najmove koji nisu završeni.
        /// </summary>
        public List<Najam> DohvatiVazeceNajmove()
        {
            List<Najam> najmovi = new List<Najam>();

            using (var db = new DBEntities())
            {
                najmovi = (from n in
                               db.Najams.Include("Korisnik").Include("Automobil").Include(m => m.Automobil.Marka).Include(m => m.Automobil.Model)
                           where n.zavrsen == false
                           select n).ToList();
            }

            return najmovi;
        }
        #endregion

        #region DohvatiSveKorisnike
        /// <summary>
        ///  Dohvaća sve korisnike.
        /// </summary>
        public dynamic DohvatiSveKorisnike()
        {
            using (var db = new DBEntities())
            {
                var korisnici = from k in db.Korisniks
                                from u in db.Ulogas
                                where k.id_uloga == u.id_uloga
                                select new
                                {
                                    ID = k.id_korisnik,
                                    Uloga = u.uloga1,
                                    Ime = k.ime,
                                    Prezime = k.prezime,
                                    Korisnicko_ime = k.korisnicko_ime,
                                    OIB = k.oib,
                                    Broj_vozacke = k.broj_vozacke,
                                    Lozinka = k.lozinka
                                };
                return korisnici.ToList();
            }
        }
        #endregion

        #region PronadiAutomobilZaNajam
        /// <summary>
        ///  Dohvaća automobil koji se koristio u najmu.
        /// </summary>
        /// <param name="najam"> Najam za koji tražimo automobil. </param>
        public Automobil PronadiAutomobilZaNajam(Najam najam)
        {
            Automobil automobil = null;

            using (var db = new DBEntities())
            {
                automobil = (from a in db.Automobils.Include("Model").Include("Marka") where a.id_automobil == najam.id_automobil select a).FirstOrDefault();
            }

            return automobil;
        }
        #endregion

        #region PostojiTablica
        /// <summary>
        ///  Provjerava postoji li automobil sa tablicom u bazi.
        /// </summary>
        /// <param name="tablica"> Tablica za koju tražimo automobil. </param>
        public bool PostojiTablica(string tablica)
        {
            bool postoji = false;
            using (var db = new DBEntities())
            {
                int upit = (from a in db.Automobils where a.tablica == tablica select a).Count();
                if (upit > 0)
                {
                    postoji = true;
                }
            }
            return postoji;
        }
        #endregion

        #region ProvjeriIspravnost
        /// <summary>
        ///  Provjerava postoje li greške.
        /// </summary>
        public bool ProvjeriIspravnost(Automobil automobil)
        {
            if (DohvatiGreske(automobil) == "")
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region DohvatiGreske
        /// <summary>
        ///  Dohvaća sve greške.
        /// </summary>
        public string DohvatiGreske(Automobil automobil)
        {
            string greske = "";

            if (automobil.tablica == "")
            {
                greske += "Tablica nije unesena." + Environment.NewLine;
            }
            if (automobil.godiste.ToString() == "")
            {
                greske += "Godište nije uneseno." + Environment.NewLine;
            }
            if (automobil.slika == null)
            {
                greske += "Slika nije dodana." + Environment.NewLine;
            }

            Evidencija evidencija = new Evidencija();
            if (evidencija.PostojiTablica(automobil.tablica))
            {
                greske += "Tablica već postoji." + Environment.NewLine;
            }

            return greske;
        }
        #endregion

        #region DohvatiUloge
        /// <summary>
        ///  Dohvaća nazive uloga.
        /// </summary>
        public dynamic DohvatiUloge()
        {
            using (var db = new DBEntities())
            {
                var uloga = from u in db.Ulogas
                            select u.uloga1;
                return uloga.ToList();
            }
        }
        #endregion

        #region PronadiUlogu
        /// <summary>
        ///  Pronalazi ulogu po nazivu.
        /// </summary>
        public int PronadiUlogu(string naziv)
        {
            using (var db = new DBEntities())
            {
                var uloga = (from u in db.Ulogas
                             where u.uloga1 == naziv
                             select u).ToList();
                return uloga[0].id_uloga;
            }
        }
        #endregion

        #region IzbrisiKorisnika
        /// <summary>
        ///  Briše odabranog korisnika iz baze podataka.
        /// </summary>
        public void IzbrisiKorisnika(Korisnik korisnik)
        {
            using (var db = new DBEntities())
            {
                db.Korisniks.Attach(korisnik);
                db.Korisniks.Remove(korisnik);
                db.SaveChanges();
            }
        }
        #endregion

        #region PronadiKorisnike
        /// <summary>
        ///  Pronalazi korisnike po tekstu unutar txtbox pretrage.
        /// </summary>
        public dynamic PronadiKorisnike(string tekst)
        {
            using (var db = new DBEntities())
            {
                if (tekst != "")
                {
                    var korisnici = from k in db.Korisniks
                                    from u in db.Ulogas
                                    where k.id_uloga == u.id_uloga && (u.uloga1.Contains(tekst) || k.korisnicko_ime.Contains(tekst) || k.ime.Contains(tekst) || k.prezime.Contains(tekst) || k.oib.Contains(tekst))
                                    select new
                                    {
                                        ID = k.id_korisnik,
                                        Uloga = u.uloga1,
                                        Ime = k.ime,
                                        Prezime = k.prezime,
                                        Korisnicko_ime = k.korisnicko_ime,
                                        OIB = k.oib,
                                        Broj_vozacke = k.broj_vozacke,
                                        Lozinka = k.lozinka
                                    };
                    return korisnici.ToList();
                }
                else
                {
                    var korisnici = from k in db.Korisniks
                                    from u in db.Ulogas
                                    where k.id_uloga == u.id_uloga
                                    select new
                                    {
                                        ID = k.id_korisnik,
                                        Uloga = u.uloga1,
                                        Ime = k.ime,
                                        Prezime = k.prezime,
                                        Korisnicko_ime = k.korisnicko_ime,
                                        OIB = k.oib,
                                        Broj_vozacke = k.broj_vozacke,
                                        Lozinka = k.lozinka
                                    };
                    return korisnici.ToList();
                }

            }
        }
        #endregion

        #region DohvatiZauzeteDatume
        /// <summary>
        ///  Dohvaća zauzete datume iz baze
        /// </summary>
        public List<DateTime> DohvatiZauzeteDatume()
        {
            List<DateTime> zauzeti = new List<DateTime>();
            using (var db = new DBEntities())
            {
                var datumi = (from datum in db.Najams
                              where datum.zavrsen == false
                              select new
                              {
                                  datum.datum_najma,
                                  datum.datum_povrata
                              }).ToList();

                foreach (var datum in datumi)
                {
                    double brojDana = (datum.datum_povrata - datum.datum_najma).TotalDays;
                    for (int i = 0; i <= brojDana; i++)
                    {
                        zauzeti.Add(datum.datum_najma.AddDays(i).Date);
                    }
                }
            }

            return zauzeti;
        }
        #endregion

        #region DodajKorisnika
        /// <summary>
        ///  Dodaje korisnika u bazu podataka.
        /// </summary>
        public void DodajKorisnika(Korisnik korisnik)
        {
            using (var db = new DBEntities())
            {
                db.Korisniks.Attach(korisnik);
                db.Korisniks.Add(korisnik);
                db.SaveChanges();
            }
        }
        #endregion

        #region Spremi(Automobil)
        public int Spremi(Automobil automobil)
        {
            int rezultat;

            using (var db = new DBEntities())
            {
                db.Automobils.Add(automobil);
                rezultat = db.SaveChanges();
            }
            return rezultat;
        }
        #endregion

        #region AzurirajZavrsenNajam
        public int AzurirajZavrsenNajam(Najam najam, string stanjeNakonVoznje, decimal iznosStete)
        {
            int rezultat = 0;

            using (var db = new DBEntities())
            {
                db.Najams.Attach(najam);

                najam.nastala_steta = stanjeNakonVoznje;
                najam.iznos_štete = iznosStete;
                najam.zavrsen = true;

                rezultat = db.SaveChanges();
            }

            return rezultat;
        }
        #endregion

        #region Obrisi(Najam)
        public int Obrisi(Najam najam)
        {
            int rezultat = 0;

            using (var db = new DBEntities())
            {
                db.Najams.Attach(najam);
                db.Najams.Remove(najam);
                rezultat = db.SaveChanges();
            }

            return rezultat;
        }
        #endregion

        #region AzurirajKorisnika
        /// <summary>
        ///  Ažurira postojećeg korisnika u bazi podataka.
        /// </summary>
        public void AzurirajKorisnika(Korisnik korisnikZaIzmjenu, Korisnik izmjenjenKorisnik)
        {
            using (var db = new DBEntities())
            {
                db.Korisniks.Attach(korisnikZaIzmjenu);
                korisnikZaIzmjenu.id_uloga = izmjenjenKorisnik.id_uloga;
                korisnikZaIzmjenu.korisnicko_ime = izmjenjenKorisnik.korisnicko_ime;
                korisnikZaIzmjenu.ime = izmjenjenKorisnik.ime;
                korisnikZaIzmjenu.prezime = izmjenjenKorisnik.prezime;
                korisnikZaIzmjenu.oib = izmjenjenKorisnik.oib;
                korisnikZaIzmjenu.broj_vozacke = izmjenjenKorisnik.broj_vozacke;
                korisnikZaIzmjenu.lozinka = izmjenjenKorisnik.lozinka;
                db.SaveChanges();
            }
        }
        #endregion

        #region DohvatiAutomobilIzNajma
        /// <summary>
        ///  Dohvaća Id Automobila iz najma
        /// </summary>
        public Automobil DohvatiAutomobilIzNajma(Najam najam)
        {
            List<Automobil> lista;
            Automobil auto;
            using (var db = new DBEntities())
            {
                db.Najams.Attach(najam);
                var automobil = from a in db.Automobils
                                where a.id_automobil == najam.id_automobil
                                select a;
                lista = automobil.ToList();
                auto = lista.First();
                
            }
            return auto;
        }
        #endregion

        #region DohvatiAutomobileNaServisu
        /// <summary>
        ///  Dohvaća sve automobile koji su na servisu
        /// </summary>
        public List<Automobil> DohvatiAutomobileNaServisu()
        {
            List<Automobil> lista;
            using (var db = new DBEntities())
            {
                var automobili = from a in db.Automobils.Include("Lokacija").Include("Status").Include("Marka").Include("Model")
                                where a.id_status == 2
                                select a;
                lista = automobili.ToList();
           
            }

            return lista;
        }
        #endregion

        #region DohvatiSveNajmove
        /// <summary>
        ///  Dohvaća sve korisnike.
        /// </summary>
        public List<Najam> DohvatiSveNajmove()
        {
            List<Najam> najmovi;
            using (var db = new DBEntities())
            {
                najmovi = (from n in
                              db.Najams.Include("Korisnik").Include("Automobil").Include(m => m.Automobil.Marka).Include(m => m.Automobil.Model)
                           select n).ToList();
                return najmovi;
            }
        }
        #endregion

        #region DohvatiKorisnikeCmb
        /// <summary>
        ///  Dohvaća sve korisnike.
        /// </summary>
        public List<Korisnik> DohvatiKorisnikeCmb()
        {
            List<Korisnik> koriscnici;
            using (var db = new DBEntities())
            {
                koriscnici = (from k in db.Korisniks
                              select k).ToList();
                return koriscnici;
            }
        }
        #endregion

        #region AzurirajNajam
        /// <summary>
        ///  Ažurira postojeći najam u bazi podataka.
        /// </summary>
        public int AzurirajNajam(Najam najamZaIzmjenu, Najam izmjenjenNajam)
        {
            int rezultat = 0;
            using (var db = new DBEntities())
            {
                db.Najams.Attach(najamZaIzmjenu);
                najamZaIzmjenu.id_najam = izmjenjenNajam.id_najam;
                najamZaIzmjenu.id_automobil = izmjenjenNajam.id_automobil;
                najamZaIzmjenu.id_korisnik = izmjenjenNajam.id_korisnik;
                najamZaIzmjenu.datum_najma = izmjenjenNajam.datum_najma;
                najamZaIzmjenu.datum_povrata = izmjenjenNajam.datum_povrata;
                najamZaIzmjenu.nastala_steta = izmjenjenNajam.nastala_steta;
                najamZaIzmjenu.iznos_štete = izmjenjenNajam.iznos_štete;
                najamZaIzmjenu.zavrsen = izmjenjenNajam.zavrsen;
                rezultat = db.SaveChanges();
            }
            return rezultat;
        }
        #endregion

        #region ProvjeriKorIme
        /// <summary>
        ///  Pronalazak korisničkog imena kod registracije.
        /// </summary>
        /// <param name="korisnickoIme"> Koristi se za pronalazak korisničkog imena </param>
        public Korisnik ProvjeriKorIme(string korisnickoIme)
        {
            Korisnik korisnik = null;

            using (var db = new DBEntities())
            {
                korisnik = (from k
                            in db.Korisniks
                            where k.korisnicko_ime == korisnickoIme
                            select k).FirstOrDefault();
            }
            return korisnik;
        }
        #endregion
    }
}
        