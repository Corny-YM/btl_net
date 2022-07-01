using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.BUS
{
    public class Crystal_Report_Document_to_Viewer
    {
        public static void Handle(CrystalReportViewer vw_rp, string file_name_rp )
        {
            ReportDocument rp = new ReportDocument();
            rp.Load(file_name_rp);
            rp.SetDatabaseLogon("root", "");
            vw_rp.ReportSource = rp;
        }
    }
}
