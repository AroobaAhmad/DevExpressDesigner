using DevExpress.XtraReports.UI;

namespace WebApplication1.Reports
{
    public partial class EurotracsCleaningDocumentSubReport : XtraReport
    {
        private const string ReportName = "EurotracsCleaningDocumentReport";

        private static readonly string ReportsDirectory =
            "D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports";
        private static readonly string RepxPath = Path.Combine(ReportsDirectory, $"{ReportName}.repx");
        public EurotracsCleaningDocumentSubReport()
        {
            InitializeComponent();
          //  SaveLayoutToXml(RepxPath);
        }

        //protected override void OnBeforePrint(PrintEventArgs e)
        //{
        //    var cleaningOrderID = int.Parse(Parameters["CleaningOrderID"].Value.ToString());
        //    var companyID = short.Parse(Parameters["CompanyID"].Value.ToString());
        //    spEurotracsCleaningDocumentCompartmentSelectTableAdapter.Fill(((EurotracsCleaningDocumentDataSet)DataSource).spEurotracsCleaningDocumentCompartmentSelect, cleaningOrderID, companyID);
        //    base.OnBeforePrint(e);
        //}
    }
}
