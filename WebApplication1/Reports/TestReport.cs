using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WebApplication1.Reports
{
    public partial class TestReport : CustomReportImplementation
    {
        private const string ReportName = "TestReport";

        private static readonly string ReportsDirectory =
            "D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports";
        private static readonly string RepxPath = Path.Combine(ReportsDirectory, $"{ReportName}.repx");

        public TestReport()
        {
            // Generate initial layout from VS designer and save to .repx
            InitializeComponent();
            SaveLayoutToXml(RepxPath);
        }
        protected override void InjectEvents()
        {
            if (FindControl("xrTableCell3", true) is XRLabel label)
            {
                System.Diagnostics.Debug.WriteLine("BeforePrint callinggg ... ");
                label.BeforePrint += Label_BeforePrint;
            }
            if (FindControl("xrTableCell6", true) is XRLabel label2)
            {
                System.Diagnostics.Debug.WriteLine("BeforePrint callinggg ... ");
                label2.BeforePrint += Label_BeforePrint;
            }
        }

        private void Label_BeforePrint(object sender, CancelEventArgs e)
        {
            var label = sender as XRLabel;
            if (label != null)
            {
                var value = GetCurrentColumnValue("Place");
                label.Visible = value != DBNull.Value && Convert.ToBoolean(value);
            }
        }

    }
}
