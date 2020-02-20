using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Baza
    {
        OleDbConnection con;

        public OleDbConnection Con { get => con; set => con = value; }

        public Baza()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BazaPodataka\TVP.accdb");
        }
        public void otvoriKon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
        public void zatvoriKon()
        {
            con.Close();
        }
       
    }
}
