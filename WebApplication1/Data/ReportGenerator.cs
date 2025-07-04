using System.Data;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;
using Microsoft.Data.SqlClient;
using WebApplication1.Reports;

namespace WebApplication1.Data
{
    public class ReportGenerator
    {
        public EurotracsCleaningDocumentReport GenerateReport()
        {
            var report = new EurotracsCleaningDocumentReport();

            var companyInfo = new ReportCompanyDTO("SSI", "Street1", "Lahore", "54000", "92", "Pakistan", "10");
            //report.SetCompanyInfo(companyInfo);

            //// Create the dataset (schema must match the report's .repx expectations)
            ////var dataSet = new EurotracsCleaningDocumentDataSet();

            //using var conn = new SqlConnection(
            //    "Data Source=20.160.57.109;User ID=Eurotracs;Password=P@ssw0rd;Initial Catalog=ETransDEV;Persist Security Info=true;TrustServerCertificate=true");

            //conn.Open();

            //// First SP: spEurotracsCleaningDocumentSelect
            //using (var cmd1 = new SqlCommand("report.spEurotracsCleaningDocumentSelect", conn))
            //{
            //    cmd1.CommandType = CommandType.StoredProcedure;
            //    cmd1.Parameters.AddWithValue("@CleaningOrderID", 1);
            //    cmd1.Parameters.AddWithValue("@CompanyID", 1);

            //    using var adapter1 = new SqlDataAdapter(cmd1);
            //    //adapter1.Fill(dataSet, "spEurotracsCleaningDocumentSelect");
            //}

            //// Second SP: spEurotracsLoadListSelect
            //using (var cmd2 = new SqlCommand("report.spEurotracsLoadListSelect", conn))
            //{
            //    cmd2.CommandType = CommandType.StoredProcedure;
            //    cmd2.Parameters.AddWithValue("@CompanyID", 1);
            //    cmd2.Parameters.AddWithValue("@TripID", 1);
            //    using var adapter2 = new SqlDataAdapter(cmd2);
            //    adapter2.Fill(dataSet, "spEurotracsLoadListSelect");
            //}

            //// Assign full dataset to the report
            //report.DataSource = dataSet;
            ////report.DataMember = "spEurotracsCleaningDocumentSelect"; // Optional, if main detail band is tied to this

           // report.CreateDocument();
            return report;
        }

    }
}
