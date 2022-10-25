using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pecuaria
{
    public partial class Form5 : Form
    {
        DataTable dt = new DataTable();

        public Form5(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new 
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet1, DataSet2, DataSet3, DataSet4", dt));

            this.reportViewer1.RefreshReport();
        }
    }
}
