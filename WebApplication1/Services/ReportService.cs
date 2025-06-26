using DevExpress.XtraReports.UI;
using System.IO;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
   
    public class ReportService : IReportService
    {
        private readonly AppDbContext _db;

        public ReportService(AppDbContext db)
        {
            _db = db;
        }

        // ✅ For home page listing
        public List<ReportStorage> GetDefaultReports()
        {
            return _db.ReportStorage
                .Where(r => r.IsDefault)
                .GroupBy(r => r.Url)
                .Select(g => g.First())
                .ToList();
        }

        // ✅ Load layout for printing/designer
        public byte[]? GetReportLayout(string reportName, bool isDefault)
        {
            return _db.ReportStorage
                .Where(r => r.Url == reportName && r.IsDefault == isDefault)
                .OrderByDescending(r => r.UpdatedAt)
                .Select(r => r.ReportLayout)
                .FirstOrDefault();
        }

        // ✅ Export loaded layout to PDF
        public byte[] GeneratePdf(byte[] layout)
        {
            var report = new XtraReport();
            using var layoutStream = new MemoryStream(layout);
            report.LoadLayoutFromXml(layoutStream);
            report.CreateDocument();

            using var ms = new MemoryStream();
            report.ExportToPdf(ms);
            return ms.ToArray();
        }

        // ✅ Save a layout (used by custom upload / internal logic)
        public void SaveLayout(string reportName, byte[] layout, bool isDefault)
        {
            var existing = _db.ReportStorage
                .FirstOrDefault(r => r.Url == reportName && r.IsDefault == isDefault);

            if (existing != null)
            {
                existing.ReportLayout = layout;
                existing.UpdatedAt = DateTime.UtcNow;
            }
            else
            {
                _db.ReportStorage.Add(new ReportStorage
                {
                    Url = reportName,
                    ReportLayout = layout,
                    IsDefault = isDefault,
                    CreatedAt = DateTime.UtcNow
                });
            }

            _db.SaveChanges();
        }
    }
}
