using DevExpress.XtraReports.UI;

namespace WebApplication1.Reports
{
    public partial class EurotracsCleaningDocumentSubReport : XtraReport
    {
        public EurotracsCleaningDocumentSubReport()
        {
            InitializeComponent();
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
