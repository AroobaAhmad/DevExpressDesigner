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
            InjectEvents();
        }

        private void InjectEvents()
        {
            BeforePrint += On_BeforePrint;
        }
        public void LoadLayoutAndInjectEvents(string layoutPath)
        {
            this.LoadLayoutFromXml(layoutPath); // Load layout
            InjectEvents();                     // Hook events after loading
        }


        public void SetCompanyInfo(ReportCompanyDTO companyinfo)
        {

            // Always use FindControl after LoadLayoutFromXml
            var nameLabel = FindControl("CompanyNameLabel", true) as XRLabel;
            var streetLabel = FindControl("CompanyStreetLabel", true) as XRLabel;
            var cityLabel = FindControl("CompanyCityLabel", true) as XRLabel;
            var telLabel = FindControl("CompanyTelLabel", true) as XRLabel;
            var logoImage = FindControl("Logo", true) as XRPictureBox;

            if (nameLabel != null)
            {
                nameLabel.ExpressionBindings.Clear();
                nameLabel.Text = companyinfo.CompanyName;
            }

            if (streetLabel != null)
                streetLabel.Text = companyinfo.CompanyStreet;

            if (cityLabel != null)
                cityLabel.Text = $"{companyinfo.CompanyCountryCode}-{companyinfo.CompanyCityPostCode} {companyinfo.CompanyCityName}";

            if (telLabel != null)
                telLabel.Text = companyinfo.CompanyTelephone;

            if (logoImage != null && companyinfo.CompanyLogo != null)
                logoImage.Image = companyinfo.CompanyLogo;
        }

        private void On_BeforePrint(object sender,CancelEventArgs e)
        {
            //var subreport = sender as XRSubreport;
            //if (string.IsNullOrEmpty(subreport?.ReportSourceUrl)) return; // Use ReportSourceUrl, NOT ReportSource

            //// This is the report automatically loaded from ReportSourceUrl
            //if (subreport.ReportSource is XtraReport sub)
            //{
            //    sub.Parameters["CompID"].Value = Convert.ToInt32(GetCurrentColumnValue("CompanyID"));
            //    sub.Parameters["CleanID"].Value = Convert.ToInt32(GetCurrentColumnValue("CleaningOrderID"));
            //    sub.RequestParameters = false;
            //}
            SetCompanyInfo(new ReportCompanyDTO("Eurotracs", "Sluizeken", "Zottegem", "9620", "BE", "BELGIUM", "13"));

        }
    }
}