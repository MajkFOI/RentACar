using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;
using PoslovnaLogika;

namespace RentACar
{
    public partial class KlijentForma : Form
    {
        Evidencija evidencija;
        Korisnik trenutniKorisnik = null;
        public KlijentForma(Korisnik korisnik)
        {
            InitializeComponent();
            evidencija = new Evidencija();
            trenutniKorisnik = korisnik;
        }

        private void KlijentForma_Load(object sender, EventArgs e)
        {
            PozdravnaPoruka.Text = "Dobrodošao/la " + trenutniKorisnik.ime + " " + trenutniKorisnik.prezime + " (" + trenutniKorisnik.korisnicko_ime + ")";
            PopisAutomobila.DataSource = evidencija.DohvatiAutomobile();
            PopisAutomobila.Columns[0].Visible = false;
            PopisAutomobila.Columns[1].Visible = false;
            PopisAutomobila.Columns[2].Visible = false;
            PopisAutomobila.Columns[3].Visible = false;
            PopisAutomobila.Columns[4].Visible = false;
            PopisAutomobila.Columns[5].Visible = false;
            PopisAutomobila.Columns[6].Visible = false;
            PopisAutomobila.Columns[7].Visible = false;
            PopisAutomobila.Columns[8].Visible = false;
            PopisAutomobila.Columns[9].Visible = false;
            PopisAutomobila.Columns[10].Visible = false;
            PopisAutomobila.Columns[11].Width = 150;
            PopisAutomobila.Columns[14].HeaderText = "Trenutni status";
        }

        private void KlijentForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pocetna = new PocetnaForma();
            pocetna.Show();
        }

        private void PopisAutomobila_SelectionChanged(object sender, EventArgs e)
        {
            Pretvorba pretvorba = new Pretvorba();
            Automobil automobil = PopisAutomobila.CurrentRow.DataBoundItem as Automobil;
            SlikaAutomobila.Image = pretvorba.BinarnaUSliku(automobil.slika);

            DetaljiAutomobilaLabela.Text = "";
            DetaljiAutomobilaLabela.Text += "Snaga: " + automobil.snaga + " kWh" + Environment.NewLine;
            DetaljiAutomobilaLabela.Text += "Cijena po danu: " + automobil.cijena_po_danu + " kn" + Environment.NewLine;
            DetaljiAutomobilaLabela.Text += "Godište: " + automobil.godiste + " g." + Environment.NewLine;
        }

        private void RezervirajGumb_Click(object sender, EventArgs e)
        {
            Automobil automobil = PopisAutomobila.CurrentRow.DataBoundItem as Automobil;
            RezervirajForma rezervirajForma = new RezervirajForma(automobil, trenutniKorisnik);
            rezervirajForma.ShowDialog();
        }

        private void OdjavaGumb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KlijentForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_5.html");
        }
    }
}
