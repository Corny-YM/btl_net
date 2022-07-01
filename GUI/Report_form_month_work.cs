using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14.GUI
{
    public partial class Report_form_month_work : Form
    {
        public Report_form_month_work()
        {
            InitializeComponent();
        }

        private void Report_form_month_work_Load(object sender, EventArgs e)
        {
            BUS.Crystal_Report_Document_to_Viewer.Handle(crystalReportViewer1, @"../../Report/CrystalReport2.rpt");
        }
    }
}
