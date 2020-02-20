using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace Projekat_2
{
    public partial class frmDodajArtikal : Form
    {
        public frmDodajArtikal()
        {
            InitializeComponent();
            baza = new Baza();
            ds = new DataSet();
            dsA = new DataSet();
        }
        Baza baza;
        DataSet ds;
        DataSet dsA;
        OleDbDataAdapter da;
        private void frmDodajArtikal_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDodaj, "Dodaj artikal u bazu podataka.");
            toolTip1.SetToolTip(btnAzuriraj, "Ažuriraj selektovan artikal.");
            toolTip1.SetToolTip(btnObrisi, "Obriši selektovan/e artikal/e.");
            toolTip1.SetToolTip(pictureBox2, "Klikni za dodavanje slike artikla.");
            toolTip1.Active = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string sql = "SELECT DISTINCT id_grupa,naziv FROM GRUPA";
            
            try
            {
                baza.otvoriKon();
                da = new OleDbDataAdapter(sql, baza.Con);
                da.Fill(ds, "grupe");
                da.Dispose();
                cmbGrupa.ValueMember ="id_grupa";
                cmbGrupa.DisplayMember = "naziv";
                cmbGrupa.DataSource = ds.Tables["grupe"];
            }
            catch { }
            finally { baza.zatvoriKon(); }
        }

        private void cmbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsA.Reset();
            string sql = @"SELECT Artikal.[id_artikla], Artikal.[naziv], Artikal.[cena], Artikal.[popust]
                          FROM(Artikal INNER JOIN
                          Grupa ON Artikal.[id_artikla] = Grupa.[id_artikla])
                          WHERE Grupa.[id_grupa] = " + cmbGrupa.SelectedValue + " "+
                          "ORDER BY Artikal.id_artikla";
           
            da = new OleDbDataAdapter(sql, baza.Con);
            da.Fill(dsA, "artikli");
            dataGridView1.DataSource = dsA.Tables["artikli"];
            da.Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtCena.Text == string.Empty || txtNaziv.Text == string.Empty)
                MessageBox.Show("Greška, niste popunili sva polja za unos novog artikla!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string path = "";
               
                OleDbTransaction tr = null;
                OleDbCommand cmd = baza.Con.CreateCommand();
                OleDbCommand cmdG = baza.Con.CreateCommand();
                OleDbCommand cmdId = baza.Con.CreateCommand();
                OleDbCommand cmdSl = baza.Con.CreateCommand();

                cmd.CommandText = "INSERT INTO Artikal (naziv, cena, popust) VALUES(?,?,?)";

                cmd.Parameters.Add(new OleDbParameter("naziv", txtNaziv.Text));
                cmd.Parameters.Add(new OleDbParameter("cena", Convert.ToInt32(txtCena.Text)));
                cmd.Parameters.Add(new OleDbParameter("popust", (int)numericUpDown1.Value));

                try
                {
                    baza.otvoriKon();
                    tr = baza.Con.BeginTransaction();
                    cmd.Transaction = tr;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cmdId.CommandText = @"SELECT MAX(id_artikla)
                                              FROM Artikal
                                              WHERE (naziv=? AND cena=? AND popust=?)";
                        cmdId.Parameters.Add(new OleDbParameter("naziv", txtNaziv.Text));
                        cmdId.Parameters.Add(new OleDbParameter("cena", Convert.ToInt32(txtCena.Text)));
                        cmdId.Parameters.Add(new OleDbParameter("popust", (int)numericUpDown1.Value));
                        cmdId.Transaction = tr;
                        int id = (int)cmdId.ExecuteScalar();
                            
                        if (pictureBox2.Image != null)
                        {
                            string fname = id + ".bmp";
                            string folder = @"../../slike";
                            path = Path.Combine(folder, fname);
                        }

                        cmdSl.CommandText = @"UPDATE Artikal
                                              SET slika =?
                                              WHERE id_artikla=" + id + "";
                        cmdSl.Parameters.Add(new OleDbParameter("slika", path));
                        cmdG.CommandText = "INSERT INTO Grupa (id_grupa,id_artikla, naziv) VALUES(?,?,?)";
                        cmdG.Parameters.Add(new OleDbParameter("id_grupa", cmbGrupa.SelectedValue));
                        cmdG.Parameters.Add(new OleDbParameter("id_artikla", id));
                        cmdG.Parameters.Add(new OleDbParameter("naziv", cmbGrupa.Text));

                        cmdSl.Transaction = tr;
                        cmdG.Transaction = tr;

                        cmdSl.ExecuteNonQuery();
                        cmdG.ExecuteNonQuery();

                        tr.Commit();

                        if(path!="" || path!=null)
                            pictureBox2.Image.Save(path);
                        MessageBox.Show("Uspešno dodavanje podataka o artiklu!", "Uspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Neuspešno dodavanje podataka!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("Neuspešna akcija dodavanja podataka!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baza.zatvoriKon();
                    cmbGrupa_SelectedIndexChanged(null, null);
                    txtCena.Clear();
                    txtNaziv.Clear();
                    numericUpDown1.Value = numericUpDown1.Minimum;
                    pictureBox2.Image = null;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                fileDialog.Title = "Izaberite sliku artikla";
                fileDialog.Filter = "(.jpg, .jpeg, .bmp, .png)|*.jpg;*.jpeg;*.bmp;*.png";
                if(fileDialog.ShowDialog()==DialogResult.OK)
                {
                    p.Image = Image.FromFile(fileDialog.FileName);
                }
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                frmUpdate frm = new frmUpdate(dataGridView1.SelectedRows);
                frm.ShowDialog();
                cmbGrupa_SelectedIndexChanged(null, null);
            }
            else
                MessageBox.Show("Ne možete ažurirati više redova istovremeno!","Greška!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li želite da obrišete " + dataGridView1.SelectedRows.Count + (dataGridView1.SelectedRows.Count == 1 ? " red" : " reda") + " podataka?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] ids = new int[dataGridView1.SelectedRows.Count];
                int n = 0;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ids[n++] = (int)row.Cells[0].Value;
                }
                string allIDs = "" + string.Join(",", ids);

                OleDbCommand cmdP = baza.Con.CreateCommand();
                cmdP.CommandText = @"SELECT slika
                                FROM Artikal
                                WHERE id_artikla IN (" + allIDs + ")";
                OleDbCommand cmds = baza.Con.CreateCommand();
                cmds.CommandText = @"DELETE FROM Artikal
                                WHERE id_artikla IN(" + allIDs + ")";

                List<string> paths = new List<string>();
                
                try
                {
                    baza.otvoriKon();
                    OleDbDataReader dataReader = cmdP.ExecuteReader();
                    while (dataReader.Read())
                        paths.Add(dataReader.GetString(0));

                    if (cmds.ExecuteNonQuery() > 0)
                    {
                        foreach (string putanja in paths)
                        {
                            if (putanja != "" || putanja != null)
                            {
                                string path = Path.Combine(putanja);
                                if (File.Exists(path))
                                {
                                    File.Delete(path);
                                }
                            }
                        }
                        cmbGrupa_SelectedIndexChanged(null, null);
                        MessageBox.Show("Obrisano!", "Uspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Nije obrisano!", "Neuspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show("Akcija brisanja nije uspela, pokušajte ponovo!"); }
                finally
                {
                    baza.zatvoriKon();
                }
            }
        }
        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void txtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
