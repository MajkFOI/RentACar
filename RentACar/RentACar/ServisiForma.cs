using System;
using Podaci;
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
    public partial class ServisiForma : Form
    {
        public ServisiForma()
        {
            InitializeComponent();
        }

        public void Osvjezipopis()
        {
            Evidencija evidencija = new Evidencija();
            PopisAutomobilaNaServisu.DataSource = evidencija.DohvatiAutomobileNaServisu();
            PopisAutomobilaNaServisu.Columns[0].Visible = false;
            PopisAutomobilaNaServisu.Columns[1].Visible = false;
            PopisAutomobilaNaServisu.Columns[2].Visible = false;
            PopisAutomobilaNaServisu.Columns[3].Visible = false;
            PopisAutomobilaNaServisu.Columns[4].Visible = false;
            PopisAutomobilaNaServisu.Columns[5].Visible = false;
            PopisAutomobilaNaServisu.Columns[6].Visible = false;
            PopisAutomobilaNaServisu.Columns[7].Visible = false;
            PopisAutomobilaNaServisu.Columns[8].Visible = false;
            PopisAutomobilaNaServisu.Columns[9].Visible = false;
            PopisAutomobilaNaServisu.Columns[10].Visible = false;
            PopisAutomobilaNaServisu.Columns[11].Width = 150;
            PopisAutomobilaNaServisu.Columns[14].HeaderText = "Trenutni status";
        }

        private void ServisiForma_Load(object sender, EventArgs e)
        {
            Osvjezipopis();
        }

        private void AutomobilPopravljenGumb_Click(object sender, EventArgs e)
        {
            Automobil odabraniAutomobil = PopisAutomobilaNaServisu.CurrentRow.DataBoundItem as Automobil;

            using (var db = new DBEntities())
            {
                db.Automobils.Attach(odabraniAutomobil);
                odabraniAutomobil.id_status = 1;
                db.SaveChanges();
            }
            MessageBox.Show("Popravak odabranog automobila je evidentiran. Automobil je sada dostupan za rezervaciju");
            Osvjezipopis();
        }

        private void ServisiForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "RentACar.chm", HelpNavigator.Topic, "page_7.html");
        }
    }
}
