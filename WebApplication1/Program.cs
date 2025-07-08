using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Models;
using WebApplication1.Services; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDevExpressControls();
builder.Services.AddMvc();
builder.Services.AddScoped<IReportService, ReportService>();
//builder.Services.AddScoped<IReportProvider, CustomReportProvider>();
builder.Services.AddScoped<ReportStorageWebExtension>(provider =>
    new SqlReportStorage(builder.Configuration.GetConnectionString("Default")));

var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.ConfigureReportingServices(configurator => {
    configurator.UseDevelopmentMode();

    configurator.ConfigureReportDesigner(designer => {
            designer.RegisterDataSourceWizardConfigFileConnectionStringsProvider();
        });
   
});

var app = builder.Build();

app.UseDevExpressControls();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Report}/{action=Index}");

app.Run();