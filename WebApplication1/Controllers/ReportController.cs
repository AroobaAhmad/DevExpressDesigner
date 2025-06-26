using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Linq;
using WebApplication1.Models;

public class ReportController : Controller
{
    private readonly AppDbContext _db;

    public ReportController(AppDbContext db)
    {
        _db = db;
    }

    // 📄 Show default reports on home page
    public IActionResult Index()
    {
        var defaultReports = _db.ReportStorage
            .Where(r => r.IsDefault)
            .GroupBy(r => r.Url)
            .Select(g => g.First()) // get one per Url
            .ToList();

        return View(defaultReports);
    }

    public IActionResult Designer(string reportId, string version = "default")
    {
        // This just redirects to the DevExpress Designer page
        return RedirectToAction("Designer", "DevExpressDesigner", new { reportId, version });
    }

    [HttpPost]
    public IActionResult Print(string reportId, string version)
    {
        var useDefault = version == "default";

        var reportEntry = _db.ReportStorage
            .Where(r => r.Url == reportId && r.IsDefault == useDefault)
            .OrderByDescending(r => r.UpdatedAt)
            .FirstOrDefault();

        if (reportEntry == null)
            return NotFound("Report layout not found");

        var report = new XtraReport();
        using var layoutStream = new MemoryStream(reportEntry.ReportLayout);
        report.LoadLayoutFromXml(layoutStream);
        report.CreateDocument();

        using var pdfStream = new MemoryStream();
        report.ExportToPdf(pdfStream);

        return File(pdfStream.ToArray(), "application/pdf", $"{reportId}.pdf");
    }
}
