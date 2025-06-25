using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Web.Extensions; // for ReportStorageWebExtension

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDevExpressControls();
builder.Services.AddMvc();

builder.Services.AddScoped<ReportStorageWebExtension>(provider =>
    new SqlReportStorage(builder.Configuration.GetConnectionString("Default")));


  

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();