using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;
using WebApplication1.Services;

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
        return RedirectToAction("Designer", "DevExpressDesigner");
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

        var reportEntry = _reportService.GetReport(reportUrl, useDefault);

        if (reportEntry == null)
            return NotFound("Report layout not found");

        var report = new XtraReport();
        var pdfStream = _reportService.GeneratePdf(reportEntry.ReportLayout);

        return File(pdfStream, "application/pdf", $"{reportUrl}.pdf");
    }
}