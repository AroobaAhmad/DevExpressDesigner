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
        ReportGenerator generator = new ReportGenerator(); 
        
        XtraReport report = url.ToLower() switch
        {
            "testreport" => generator.GenerateReport(),
            _ => throw new Exception("Unknown report")
        };

        using var ms = new MemoryStream();
        report.SaveLayoutToXml(ms);
        return ms.ToArray();
    }





    public override Dictionary<string, string> GetUrls()
    {
        var dict = new Dictionary<string, string>();

        using var conn = new SqlConnection(connectionString);
        conn.Open();

        var cmd = new SqlCommand("SELECT Url FROM ReportStorage", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string name = reader.GetString(0);
            dict[name] = name;
        }

        return dict;
    }


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

        // Define the path to save the .repx file
        var reportsDirectory = Path.Combine("D:\\FleetGo\\POC - Client Designer\\New Designer\\NewDesigner\\WebApplication1\\Reports");
        Directory.CreateDirectory(reportsDirectory); // Ensure the folder exists

        var repxFilePath = Path.Combine(reportsDirectory, $"{defaultUrl}.repx");

        // Save report layout as .repx file
        using var ms = new MemoryStream();
        report.SaveLayoutToXml(repxFilePath);
        var layoutBytes = ms.ToArray();

        //save to db
        using var conn = new SqlConnection(connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
      
            INSERT INTO ReportStorage (Url, ReportLayout, CreatedAt, UpdatedAt, IsDefault) 
            VALUES (@Url, @Layout, GETDATE(), GETDATE(),1)", conn);

        cmd.Parameters.AddWithValue("@Url", defaultUrl);
        cmd.Parameters.AddWithValue("@Layout", layoutBytes);
        cmd.ExecuteNonQuery();
        return defaultUrl;
    }


}