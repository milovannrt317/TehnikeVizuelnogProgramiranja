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
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace Projekat_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ds = new DataSet();
            baza = new Baza();
           
        }
        Baza baza;
        DataSet ds;
        OleDbDataAdapter da;
        Artikal ar;
        PrikazRacuna prArt;
        List<Artikal> lista;
        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnIzdaj, "Izdaj račun.");
            toolTip1.SetToolTip(btnObrisiArt, "Obriši izabrani artikal sa liste.");
            toolTip1.SetToolTip(btnUkloniKol, "Smanji količinu za izabrani artikal.");
            toolTip1.Active = true;

            string sql = "SELECT DISTINCT id_grupa,naziv FROM GRUPA";
            da = new OleDbDataAdapter(sql, baza.Con);
            da.Fill(ds, "grupe");
            da.Dispose();

            cmbGrupa.DisplayMember = "naziv";
            cmbGrupa.ValueMember = "id_grupa";
            cmbGrupa.DataSource = ds.Tables["grupe"];

        }
        private void cmbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista = new List<Artikal>();
            panel2.Controls.Clear();
            
            OleDbCommand cmd = baza.Con.CreateCommand();
            cmd.CommandText = @"SELECT Artikal.id_artikla, Artikal.naziv, Artikal.cena, Artikal.popust, Artikal.slika
                                FROM Artikal INNER JOIN
                                Grupa ON Artikal.id_artikla = Grupa.id_artikla
                                WHERE Grupa.id_grupa = " + cmbGrupa.SelectedValue + " "+
                                "ORDER BY Artikal.naziv";
            try
            {
                Artikal a;
                baza.otvoriKon();
                OleDbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    a = new Artikal();
                    a.id_artikla = (int)dataReader[0];
                    a.naziv = (string)dataReader[1];
                    a.cena = (int)dataReader[2];
                    a.popust = (int)dataReader[3];
                    a.slika = dataReader[4] as string;
                    lista.Add(a);
                }
                puniDugmad(lista);
            }
            catch { }
            finally { baza.zatvoriKon(); }
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                dst.Tables[0].Clear();
                puni();
                OleDbCommand cmd = baza.Con.CreateCommand();
                da = new OleDbDataAdapter();

                cmd.CommandText = "INSERT INTO Racun (cena, datum, vreme) VALUES(?,?,?)";
                cmd.Parameters.Add(new OleDbParameter("cena", Convert.ToDouble(txtCenaUkupna.Text)));
                cmd.Parameters.Add(new OleDbParameter("datum", DateTime.Now.Date));
                cmd.Parameters.Add(new OleDbParameter("vreme", DateTime.Now.TimeOfDay));

                try
                {
                    baza.otvoriKon();
                    if(cmd.ExecuteNonQuery()==0)
                        MessageBox.Show("Račun nije izdat, pokušajte ponovo!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("Račun nije izdat, pokušajte ponovo!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally { baza.zatvoriKon(); }

                new Thread(() => new frmRprt(dst).ShowDialog()).Start();
                listBox2.Items.Clear();
                txtCenaUkupna.Clear();
            }
            else
                MessageBox.Show("Greška, nemate artikale za izdavanje računa!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int id= int.Parse(((Button)sender).Name);

            var art = lista.Where(x => x.id_artikla == id).Select(x => x).First();
            bool flg = false;
            PrikazRacuna pr = new PrikazRacuna();

            pr.id_artikla = art.id_artikla;
            pr.naziv = art.naziv;
            pr.cena = art.cena;
            pr.popust = art.popust;
            pr.kolicina = 1;

            foreach (object o in listBox2.Items)
                if (pr.id_artikla == ((PrikazRacuna)o).id_artikla)
                {
                    flg = true;
                    break;
                }
            if (!flg)
                listBox2.Items.Add(pr);
            else
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                    if (pr.id_artikla == ((PrikazRacuna)listBox2.Items[i]).id_artikla)
                    {
                        pr.kolicina = ((PrikazRacuna)listBox2.Items[i]).kolicina + pr.kolicina;
                        listBox2.Items.RemoveAt(i);
                        listBox2.Items.Insert(i, pr);
                        break;
                    }
            }
            racunajUkupnuCenu();
        }
        private void racunajUkupnuCenu()
        {
            double cenaUkup = 0;
            foreach (object o in listBox2.Items)
                cenaUkup += ((PrikazRacuna)o).cena * ((PrikazRacuna)o).kolicina - (((PrikazRacuna)o).popust / 100 * ((PrikazRacuna)o).cena * ((PrikazRacuna)o).kolicina);
            txtCenaUkupna.Text = "" + cenaUkup;
        }
        private void puniDugmad(List<Artikal> lista)
        {
            int brRedova = lista.Count / 3;
            if (lista.Count % 3 != 0)
                brRedova++;

            int dimenzije = 158;
            Size sz = new Size(dimenzije, dimenzije);
            int pozX = 0;
            int pozY = 0;
            int brDug = 3;
            int n = 0;
            for (int i = 0; i < brRedova; i++)
            {
                pozY = (dimenzije + 10) * i;
                if (lista.Count - brDug * i < 3)
                    brDug = lista.Count - brDug * i;
                for (int j = 0; j < brDug; j++)
                {
                    Button btn = new Button();
                    pozX = (dimenzije + 10) * j;

                    btn.Location = new Point(pozX, pozY);
                    btn.Name = "" + lista[n].id_artikla;
                    btn.Size = new Size(dimenzije, dimenzije);
                    toolTip1.SetToolTip(btn, lista[n].naziv);

                    if (lista[n].slika == null || lista[n].slika == "")
                        btn.Text = lista[n++].naziv;
                    else
                    {
                        string path = Path.Combine(lista[n].slika);
                        if (File.Exists(path))
                        {
                            Image img = Image.FromFile(path);
                            Bitmap bmp = new Bitmap(img, sz);
                            btn.Image = bmp;
                            btn.ImageAlign = ContentAlignment.MiddleCenter;
                            n++;
                        }
                        else
                            btn.Text = lista[n++].naziv;
                    }
                    btn.BackColor = Color.White;
                    btn.Click += btn_Click;
                    panel2.Controls.Add(btn);
                }
                pozX = 0;
            }
        }
        private void puni()
        {
            foreach (object o in listBox2.Items)
            {
                PrikazRacuna p = (PrikazRacuna)o;
                DataRow dr = dst.Tables[0].NewRow();
                dr["id"] = p.id_artikla;
                dr["naziv"] = p.naziv;
                dr["cena"] = p.cena;
                dr["popust"] = p.popust;
                dr["kolicina"] = p.kolicina;
                dst.Tables[0].Rows.Add(dr);
            }
        }
        private void btnObrisiArt_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex != -1)
                listBox2.Items.RemoveAt(listBox2.Items.IndexOf((PrikazRacuna)listBox2.SelectedItem));
            else
                MessageBox.Show("Greška, niste izabrali artikal za brisanje!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            racunajUkupnuCenu();
        }
        private void btnUkloniKol_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                prArt = ((PrikazRacuna)listBox2.SelectedItem);
                for (int i = 0; i < listBox2.Items.Count; i++)
                    if (((PrikazRacuna)listBox2.SelectedItem).id_artikla == ((PrikazRacuna)listBox2.Items[i]).id_artikla)
                    {
                        ((PrikazRacuna)listBox2.SelectedItem).kolicina = ((PrikazRacuna)listBox2.Items[i]).kolicina - (int)numericUpDown2.Value;
                        listBox2.Items.RemoveAt(i);
                        listBox2.Items.Insert(i, prArt);
                        break;
                    }
            }
            else
                MessageBox.Show("Greška, niste izabrali artikal za uklanjanje zadate količine!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            racunajUkupnuCenu();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnObrisiArt.Enabled = true;
            btnUkloniKol.Enabled = true;
            if (listBox2.SelectedIndex != -1)
                numericUpDown2.Maximum = ((PrikazRacuna)listBox2.SelectedItem).kolicina - 1;
        }
        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}