using Podaci;
using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class PocetnaForma : Form
    {
        Evidencija evidencija = new Evidencija();
        public PocetnaForma()
        {
            InitializeComponent();
            evidencija = new Evidencija();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
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

        private void PrijavaGumb_Click(object sender, EventArgs e)
        {
            PrijavaForma prijava = new PrijavaForma();
            prijava.ShowDialog();
            this.Hide();
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistriraj_Click(object sender, EventArgs e)
        {
            RegistracijaForma registracija = new RegistracijaForma();
            registracija.ShowDialog();
        }

        private void PocetnaForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_2.html");
            }
            if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show
                    (
                        "Podaci za prijavu: " + Environment.NewLine +
                        "Administrator: mmaric 123" + Environment.NewLine +
                        "Zaposlenik: aantic 123" + Environment.NewLine + 
                        "Korisnik: pperic 123" + Environment.NewLine
                    );
            }
        }
    }
}
