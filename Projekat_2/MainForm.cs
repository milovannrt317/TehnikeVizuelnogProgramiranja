using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class MainForm : Form
    {
        DataSet ds;
        public MainForm()
        {
            InitializeComponent();
            ds = new DataSet();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dodajNaRačunToolStripMenuItem_Click(null, null);
            Parallel.For(0, 3, ucitajTabele);
        }

        private void dodajNaRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            PraviFormu(frm, this);
        }

        private void dodajArtikalUBazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajArtikal frm = new frmDodajArtikal();
            PraviFormu(frm,this);
        }

        private void prikazRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazRacuna frm = new frmPrikazRacuna();
            PraviFormu(frm, this);
        }

        private void napustiProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PraviFormu(Form child, Form parent)
        {
            foreach (Form fr in parent.MdiChildren)
                fr.Close();

            child.MdiParent = parent;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            child.Show();
        }
        private void ucitajTabele(int i)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BazaPodataka\TVP.accdb");
            OleDbDataAdapter da;
            if (i==0)
            {
                da = new OleDbDataAdapter("SELECT * FROM Artikal", con);
                da.Fill(ds, "Artikal");
            }
            else if(i==1)
            {
                da = new OleDbDataAdapter("SELECT * FROM Grupa", con);
                da.Fill(ds, "Grupa");
            }
            else
            {
                da = new OleDbDataAdapter("SELECT * FROM Racun", con);
                da.Fill(ds, "Racun");
            }
            

        }
    }
}
