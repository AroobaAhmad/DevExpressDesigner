using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.Extensions;
using System;
using System.Data.SqlClient;
using DevExpress.XtraReports.Services;
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
        //var path = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports", url + ".repx");

        //if (!File.Exists(path))
        //    throw new FileNotFoundException($"Report file not found: {path}");

        //return File.ReadAllBytes(path);
        XtraReport report = url.ToLower() switch
        {
            "eurotracscleaningdocumentreport" => new EurotracsCleaningDocumentReport(),
            _ => throw new Exception("Unknown report")
        };

        using var ms = new MemoryStream();
        report.SaveLayoutToXml(ms);
        return ms.ToArray();
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
//public class CustomReportProvider : IReportProvider
//{
//    public XtraReport GetReport(string url)
//    {
//        return url switch
//        {
//            "EurotracsCleaningDocumentSubReport" => new EurotracsCleaningDocumentSubReport(), // Or load from DB/Path
//            _ => throw new Exception($"Unknown report: {url}")
//        };
//    }

//    public XtraReport GetReport(string id, ReportProviderContext context)
//    {
//        throw new NotImplementedException();
//    }
//}

