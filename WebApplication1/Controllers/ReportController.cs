using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Reports;
namespace WebApplication1.Controllers;

public class ReportController : Controller
{
    private readonly IReportService _reportService;

    public ReportController(AppDbContext db, IReportService report)
    {
        _reportService = report;
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
        // redirects to the DevExpress Designer page
        return RedirectToAction("Designer", "DevExpressDesigner", new { reportId, version });
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

        var report = new EurotracsCleaningDocumentReport();
        

        using (var ms = new MemoryStream())
        {
            report.CreateDocument();
            report.ExportToPdf(ms);
            ms.Position = 0;
            return File(ms.ToArray(), "application/pdf", $"{reportUrl}.pdf");
        }
    }

}