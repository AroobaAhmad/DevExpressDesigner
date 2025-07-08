using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IReportService
    {
        List<ReportStorage> GetDefaultReports();
        byte[]? GetReportLayout(string reportName, bool isDefault);
        byte[] GeneratePdf(byte[] layout);
        void SaveLayout(string reportName, byte[] layout, bool isDefault);
        ReportStorage? GetReport(string reportName, bool isDefault);
        ReportStorage GetReport();
    }


}
