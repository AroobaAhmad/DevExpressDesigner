using DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ReportStorage> ReportStorage { get; set; }
    }

}
