using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projekat_2
{
    public partial class frmRprt : Form
    {
        public frmRprt(DataSet data)
        {
            InitializeComponent();
            set = data;
        }
        DataSet set;
        private void frmRprt_Load(object sender, EventArgs e)
        {
            ReportDataSource rpts = new ReportDataSource("DS", set.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rpts);
            reportViewer1.RefreshReport();
        }
    }
}
