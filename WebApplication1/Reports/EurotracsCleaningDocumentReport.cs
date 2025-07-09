using System.ComponentModel;
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
                // SaveLayoutToXml(RepxPath);
            InjectEvents();
        }

        private void InjectEvents()
        {
            SubReportCompartments.BeforePrint += SubReportCompartments_BeforePrint;
        }


        public void SetCompanyInfo(ReportCompanyDTO companyinfo)
        {
            //Logo.Image = companyinfo.CompanyLogo;
            CompanyNameLabel.Text = companyinfo.CompanyName;
            CompanyStreetLabel.Text = companyinfo.CompanyStreet;
            CompanyCityLabel.Text = $@"{companyinfo.CompanyCountryCode}-{companyinfo.CompanyCityPostCode} {companyinfo.CompanyCityName}";
            CompanyTelLabel.Text = companyinfo.CompanyTelephone;
        }

        private void SubReportCompartments_BeforePrint(object sender,CancelEventArgs e)
        {
            var subreportControl = (XRSubreport)sender;

            // This is the report automatically loaded from ReportSourceUrl
            if (subreportControl.ReportSource != null)
            {
                var subReport = subreportControl.ReportSource;

                subReport.Parameters["CompID"].Value = Convert.ToInt32(GetCurrentColumnValue("CompanyID"));
                subReport.Parameters["CleanID"].Value = Convert.ToInt32(GetCurrentColumnValue("CleaningOrderID"));
                subReport.RequestParameters = false;
            }
        }

        /*private T GetCurrentRowValue<T>(string columnName)
        {
            return EurotracsCleaningDocumentDataSet.spEurotracsCleaningDocumentCompartmentSelect.Rows.Count > 0
                ? EurotracsCleaningDocumentDataSet.spEurotracsCleaningDocumentCompartmentSelect.Rows[0].Field<T>(columnName)
                : default(T); // Will return null of T is a reference type
        }*/
    }
}