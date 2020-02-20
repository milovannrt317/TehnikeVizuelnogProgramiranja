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
    public partial class frmUpdate : Form
    {
        public frmUpdate(DataGridViewSelectedRowCollection row)
        {
            InitializeComponent();
            dRow = row;
            baza = new Baza();
        }
        DataGridViewSelectedRowCollection dRow;
        Baza baza;
        int id;
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            id = 0;
            foreach (DataGridViewRow row in dRow)
            {
                id = (int)row.Cells[0].Value;
                this.Text = (string)row.Cells[1].Value;
            }
            OleDbCommand cmd = baza.Con.CreateCommand();
            cmd.CommandText = @"SELECT cena,popust
                                FROM Artikal
                                WHERE id_artikla = " + id + " ";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            textBox1.DataBindings.Add("Text", ds.Tables[0], "cena");
            numericUpDown1.DataBindings.Add("Value", ds.Tables[0], "popust");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = baza.Con.CreateCommand();
            cmd.CommandText = @"UPDATE Artikal
                                SET cena=?,popust=?
                                WHERE id_artikla=" + id + "";
            cmd.Parameters.Add(new OleDbParameter("cena", int.Parse(textBox1.Text)));
            cmd.Parameters.Add(new OleDbParameter("popust", (int)numericUpDown1.Value));
            try
            {
                baza.otvoriKon();
                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Ažurirano!", "Uspešno!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nije ažurirano!", "Neuspešno!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch { MessageBox.Show("Akcija ažuriranja nije uspela, pokušajte ponovo!"); }
            finally { baza.zatvoriKon(); }
        }
        private void brojevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
