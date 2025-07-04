using System.ComponentModel;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using WebApplication1.Data;

namespace WebApplication1.Reports
{
    public partial class EurotracsCleaningDocumentReport : XtraReport, IGenericCompanyReport
    {
        private const string ReportName = "EurotracsCleaningDocumentReport";

        private static readonly string ReportsDirectory =
            "D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports";
        private static readonly string RepxPath = Path.Combine(ReportsDirectory, $"{ReportName}.repx");
        public EurotracsCleaningDocumentReport()
        {
            InitializeComponent();
            SaveLayoutToXml(RepxPath);
        }

        public void SetCompanyInfo(ReportCompanyDTO companyinfo)
        {
            //Logo.Image = companyinfo.CompanyLogo;
            CompanyNameLabel.Text = companyinfo.CompanyName;
            CompanyStreetLabel.Text = companyinfo.CompanyStreet;
            CompanyCityLabel.Text = $@"{companyinfo.CompanyCountryCode}-{companyinfo.CompanyCityPostCode} {companyinfo.CompanyCityName}";
            CompanyTelLabel.Text = companyinfo.CompanyTelephone;
        }

        /*protected override void OnBeforePrint(PrintEventArgs e)
        {
            base.OnBeforePrint(e);
            try
            {
                lblAllertec.Text = GetCurrentRowValue<bool?>("IsAllertec") ?? false ? "Positive" : "Negative";
            }
            catch(Exception ex)
            {

            }
        }*/

        private void SubReportCompartments_BeforePrint(object sender,CancelEventArgs e)
        {
            SubReportCompartments.WidthF = (float)250;
            SubReportCompartments.HeightF = (float)340;

            ((XRSubreport)sender).ReportSource.Parameters["CompanyID"].Value = Convert.ToInt32(GetCurrentColumnValue("CompanyID"));
            ((XRSubreport)sender).ReportSource.Parameters["CleaningOrderID"].Value = Convert.ToInt32(GetCurrentColumnValue("CleaningOrderID"));
        }

        //private T GetCurrentRowValue<T>(string columnName)
        //{
        //    return EurotracsCleaningDocumentDataSet.spEurotracsCleaningDocumentCompartmentSelect.Rows.Count > 0
        //        ? EurotracsCleaningDocumentDataSet.spEurotracsCleaningDocumentCompartmentSelect.Rows[0].Field<T>(columnName)
        //        : default(T); // Will return null of T is a reference type
        //}
    }
}