using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Racun
    {
       public int id_racuna { get; set; }
        public double cena { get; set; }
        public DateTime datum { get; set; }
        public DateTime vreme { get; set; }


        public static DataTable formatirajVreme(DataSet ds)
        {
            DataTable dtCloned = ds.Tables[0].Clone();
            foreach (DataColumn c in ds.Tables[0].Columns)
            {
                if ("vreme" == c.ColumnName)
                {
                    dtCloned.Columns[c.ColumnName].DataType = typeof(string);
                }
            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drw = dtCloned.NewRow();
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {

                    if ("vreme" == dc.ColumnName)
                    {
                        DateTime dt = (DateTime)dr[dc];
                        drw.SetField(dc.ColumnName, dt.ToString("hh:mm tt"));
                    }
                    else
                        drw.SetField(dc.ColumnName, dr[dc]);
                }
                dtCloned.Rows.Add(drw);
            }
            dtCloned.Columns[0].ColumnName = "broj računa";
            return dtCloned;
        }
    }
}
