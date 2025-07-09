using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.XtraExport;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel.Design;
using WebApplication1.Models;
using WebApplication1.Reports;
using WebApplication1.Services;
namespace WebApplication1.Controllers;

public class ReportController : Controller
{
    private readonly IReportService _reportService;
    private readonly IReportProvider _reportProvider;
    public ReportController(AppDbContext db, IReportService report, IReportProvider reportProvider)
    {
        _reportService = report;
        _reportProvider = reportProvider;
    }

    // Show default reports on home page
    public IActionResult Index()
    {
        string reportsDirectory = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports");

        var reportFiles = Directory.GetFiles(reportsDirectory, "*.repx")
            .Where(file => !Path.GetFileNameWithoutExtension(file).Contains("_default")) 
            .Select(Path.GetFileNameWithoutExtension)
            .ToList(); 
        var defaultReports = reportFiles.Select(path => new ReportInfo
        {
            Url = Path.GetFileNameWithoutExtension(path),
        }).ToList();

        return View(defaultReports);
    }


    public IActionResult Designer(string reportId, string version = "default")
    {
        var resolvedReportId = version == "default"
            ? $"{reportId}_default"
            : reportId;

        // Redirect to the actual designer controller/action
        return RedirectToAction("Designer", "DevExpressDesigner", new { reportId = resolvedReportId, version });
    }


    [HttpPost]
    public IActionResult Print(string reportUrl, string version)
    {
        var useDefault = version == "default";

        // Construct file path to the .repx file
        var reportsDirectory = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports");
        var reportFileName = useDefault
            ? $"{reportUrl}_default.repx"
            : $"{reportUrl}.repx";

        var reportPath = Path.Combine(reportsDirectory, reportFileName);

        if (!System.IO.File.Exists(reportPath))
            return NotFound("Report layout not found");
        //var report = new EurotracsCleaningDocumentReport();

        var report = new EurotracsCleaningDocumentReport();
        report.LoadLayoutFromXml(reportPath);
        ((IServiceContainer)report).RemoveService(typeof(IReportProvider));
        ((IServiceContainer)report).AddService(typeof(IReportProvider), _reportProvider);
        report.CreateDocument();
        using (var ms = new MemoryStream())
        {
            report.ExportToPdf(ms);
            ms.Position = 0;
            return File(ms.ToArray(), "application/pdf", $"{reportUrl}.pdf");
        }
    }
    //[HttpPost]
    //public IActionResult Print(string reportUrl, string version)
    //{
    //    bool useDefault = version?.Equals("default", StringComparison.OrdinalIgnoreCase) ?? false;

    //    // Fetch layout bytes from your database
    //    byte[]? layoutBytes = _reportService.GetReportLayout(reportUrl, useDefault);

    //    // Load layout from byte array
    //    var report = new XtraReport();
    //    using (var ms = new MemoryStream(layoutBytes))
    //    {
    //        report.LoadLayoutFromXml(ms);
    //    }

    //    // Export to PDF
    //    using (var pdfStream = new MemoryStream())
    //    {
    //        report.ExportToPdf(pdfStream);
    //        pdfStream.Position = 0;

    //        return File(pdfStream.ToArray(), "application/pdf", $"{reportUrl}.pdf");
    //    }
    //}

}