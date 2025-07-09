using DevExpress.XtraReports;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.Extensions;
using System;
using System.Data.SqlClient;
using WebApplication1.Data;
using WebApplication1.Reports;

namespace WebApplication1;

public class SqlReportStorage(string? connectionString) : ReportStorageWebExtension
{
    public override bool CanSetData(string url) => true;
    public override bool IsValidUrl(string url)
    {
        return !string.IsNullOrWhiteSpace(url)
               && url.IndexOfAny(Path.GetInvalidFileNameChars()) < 0
               && !url.Contains("/");
    }
    public override byte[] GetData(string url)
    {
        var path = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports", url + ".repx");

        if (!File.Exists(path))
            throw new FileNotFoundException($"Report file not found: {path}");
        XtraReport report = url.ToLower() switch
        {
            "eurotracscleaningdocumentreport" => new EurotracsCleaningDocumentReport(),
            "eurotracscleaningdocumentreport_default" => new EurotracsCleaningDocumentReport(),
            "eurotracscleaningdocumentsubreport" => new EurotracsCleaningDocumentSubReport(),
            _ => throw new Exception("Unknown report")
        };

        report.LoadLayoutFromXml(path);
        using var ms = new MemoryStream();
        report.SaveLayoutToXml(ms);
        return ms.ToArray();
        //XtraReport report = url.ToLower() switch
        //{
        //    "eurotracscleaningdocumentreport" => new EurotracsCleaningDocumentReport(),
        //    _ => throw new Exception("Unknown report")
        //};

        //using var ms = new MemoryStream();
        //report.SaveLayoutToXml(ms);
        //return ms.ToArray();

        //var parts = url.Split("::", StringSplitOptions.RemoveEmptyEntries);
        //var baseUrl = parts[0];
        //var mode = parts.Length > 1 ? parts[1].ToLower() : "default";

        //using var conn = new SqlConnection(connectionString);
        //conn.Open();

        //string query = mode == "latest"
        //    ? "SELECT TOP 1 ReportLayout FROM ReportStorage WHERE Url = @Url AND IsDefault = 0 ORDER BY UpdatedAt DESC"
        //    : "SELECT TOP 1 ReportLayout FROM ReportStorage WHERE Url = @Url AND IsDefault = 1 ORDER BY UpdatedAt DESC";

        //using var cmd = new SqlCommand(query, conn);
        //cmd.Parameters.AddWithValue("@Url", baseUrl);

        //var result = cmd.ExecuteScalar();

        //return result is byte[] layoutBytes
        //    ? layoutBytes
        //    : throw new FaultException($"Report '{baseUrl}' not found with mode '{mode}'.");



    }


    public override Dictionary<string, string> GetUrls()
    {
        var dict = new Dictionary<string, string>();

        string reportsDirectory = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports");

        if (!Directory.Exists(reportsDirectory))
            return dict;

        foreach (var file in Directory.GetFiles(reportsDirectory, "*.repx"))
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            dict[fileName] = fileName; // key and value both are names used by the designer
        }

        return dict;
    }


    //public override Dictionary<string, string> GetUrls()
    //{
    //    var dict = new Dictionary<string, string>();

    //    using var conn = new SqlConnection(connectionString);
    //    conn.Open();

    //    var cmd = new SqlCommand("SELECT Url FROM ReportStorage", conn);
    //    using var reader = cmd.ExecuteReader();

    //    while (reader.Read())
    //    {
    //        string name = reader.GetString(0);
    //        dict[name] = name;
    //    }

    //    return dict;
    //}


    public override void SetData(XtraReport report, string url)
    {
        using var ms = new MemoryStream();
        report.SaveLayoutToXml(ms);
        var layoutBytes = ms.ToArray();

        using var conn = new SqlConnection(connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
         IF EXISTS (SELECT 1 FROM ReportStorage WHERE Url = @Url AND IsDefault = 0)
            UPDATE ReportStorage 
            SET ReportLayout = @Layout, UpdatedAt = GETDATE() 
            WHERE Url = @Url AND IsDefault = 0
        ELSE
            INSERT INTO ReportStorage (Url, ReportLayout, IsDefault, UpdatedAt) 
            VALUES (@Url, @Layout, 0, GETDATE())", conn);

        cmd.Parameters.AddWithValue("@Url", url);
        cmd.Parameters.AddWithValue("@Layout", layoutBytes);
        cmd.ExecuteNonQuery();
    }

    public override string SetNewData(XtraReport report, string defaultUrl)
    {
        if (string.IsNullOrWhiteSpace(defaultUrl) || defaultUrl.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            throw new ArgumentException("Invalid report name");

        var reportsDirectory = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports");
        Directory.CreateDirectory(reportsDirectory);

        var repxFilePath = Path.Combine(reportsDirectory, $"{defaultUrl}.repx");

        byte[] layoutBytes;

        using (var ms = new MemoryStream())
        {
            report.SaveLayoutToXml(ms);         // Save into memory stream
            layoutBytes = ms.ToArray();

            File.WriteAllBytes(repxFilePath, layoutBytes); // Save the same bytes to disk
        }

        // Save to DB
        using var conn = new SqlConnection(connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
        INSERT INTO ReportStorage (Url, ReportLayout, CreatedAt, UpdatedAt, IsDefault) 
        VALUES (@Url, @Layout, GETDATE(), GETDATE(), 1)", conn);

        cmd.Parameters.AddWithValue("@Url", defaultUrl);
        cmd.Parameters.AddWithValue("@Layout", layoutBytes);
        cmd.ExecuteNonQuery();

        return defaultUrl;
    }

   

}
public class CustomReportProvider : IReportProvider
{
    public XtraReport GetReport(string url, ReportProviderContext context)
    {
        Console.WriteLine($"[CustomReportProvider] Loading report for: {url}");
        XtraReport report = url.ToLower() switch
        {
            "eurotracscleaningdocumentreport" => new EurotracsCleaningDocumentReport(),
            "eurotracscleaningdocumentreport_default" => new EurotracsCleaningDocumentReport(),
            "eurotracscleaningdocumentsubreport" => new EurotracsCleaningDocumentSubReport(),
            _ => throw new Exception("Unknown report")
        };
        var path = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports", url + ".repx");
        report.LoadLayoutFromXml(path);
        return report;
    }


    public XtraReport GetReport(string id)
    {
        throw new NotImplementedException();
    }
}


