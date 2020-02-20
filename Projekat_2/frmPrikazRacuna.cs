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
    public partial class frmPrikazRacuna : Form
    {
        public frmPrikazRacuna()
        {
            InitializeComponent();
            baza = new Baza();
            ds = new DataSet();
        }
        Baza baza;
        DataSet ds;
        OleDbDataAdapter da;
        private void frmPrikazRacuna_Load(object sender, EventArgs e)
        {
            dtDo.MaxDate = DateTime.Now.Date;
            dtOd.MaxDate = DateTime.Now.Date;
            dt.MaxDate = DateTime.Now.Date;
        
            dtDo.MinDate = dtOd.Value.Date;
            dtDoVr.MinDate = dtOdVr.Value;
            toolTip1.SetToolTip(btnPretragaDt, "Pretraga računa za odredjeni vremenski period.");
            toolTip2.SetToolTip(btnPretragaVr, "Pretraga računa za odredjeni vremenski period.");
            toolTip1.Active = true;
            toolTip2.Active = true;
        }
        private void btnPretragaDt_Click(object sender, EventArgs e)
        {
            ds.Reset();
            OleDbCommand cmd = baza.Con.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Racun WHERE datum BETWEEN ? AND ?";
            cmd.Parameters.Add(new OleDbParameter("datum", dtOd.Value.Date));
            cmd.Parameters.Add(new OleDbParameter("datum", dtDo.Value.Date));
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            try
            {
                baza.otvoriKon();
                da.Fill(ds);
                da.Dispose();
                if (Racun.formatirajVreme(ds).Rows.Count == 0)
                    MessageBox.Show("Nema podataka za traženi opseg!","Nema podataka!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    dataGridView1.DataSource = Racun.formatirajVreme(ds);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
            finally { baza.zatvoriKon(); }

        }
        private void btnPretragaVr_Click(object sender, EventArgs e)
        {
            if (dtOdVr.Value.TimeOfDay < dtDoVr.Value.TimeOfDay)
            {
                ds.Reset();
                OleDbCommand cmd = baza.Con.CreateCommand();
                cmd.CommandText = "SELECT *  FROM Racun WHERE datum=? AND vreme BETWEEN ? AND ?";
                cmd.Parameters.Add(new OleDbParameter("datum", dt.Value.Date));
                cmd.Parameters.Add(new OleDbParameter("vremeOd", dtOdVr.Value.TimeOfDay));
                cmd.Parameters.Add(new OleDbParameter("vremeDo", dtDoVr.Value.TimeOfDay));
                try
                {
                    baza.otvoriKon();
                    da = new OleDbDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    da.Dispose();

                    if (Racun.formatirajVreme(ds).Rows.Count == 0)
                        MessageBox.Show("Nema podataka za traženi opseg!", "Nema podataka!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dataGridView1.DataSource = Racun.formatirajVreme(ds);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch { }
                finally { baza.zatvoriKon(); }
            }
            else
            {
                MessageBox.Show("Vreme \"do\" mora biti veće od vremena \"od\"!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtDoVr.Focus();
            }
        }
        private void dtOd_ValueChanged(object sender, EventArgs e)
        {
            dtDo.MinDate = dtOd.Value.Date;
        }
        private void dtOdVr_ValueChanged(object sender, EventArgs e)
        {
            dtDoVr.MinDate = dtOdVr.Value;
        }
    }
}
