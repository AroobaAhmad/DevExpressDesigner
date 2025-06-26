using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using DevExpress.XtraReports.Web.ClientControls;

public class SqlReportStorage : ReportStorageWebExtension
{
    private readonly string _connectionString;

    public SqlReportStorage(string connectionString)
    {
        _connectionString = connectionString;
    }

    public override bool CanSetData(string url) => true;
    public override bool IsValidUrl(string url)
    {
        return !string.IsNullOrWhiteSpace(url)
               && url.IndexOfAny(Path.GetInvalidFileNameChars()) < 0
               && !url.Contains("/");
    }
    public override byte[] GetData(string url) // loads latest updated
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand("SELECT TOP 1 ReportLayout FROM ReportStorage WHERE Url = @Url ORDER BY IsDefault ASC, UpdatedAt DESC", conn);
        cmd.Parameters.AddWithValue("@Url", url);

        var result = cmd.ExecuteScalar();
        return result is byte[] layoutBytes
            ? layoutBytes
            : throw new FaultException($"Report '{url}' not found");
    }


    public override Dictionary<string, string> GetUrls()
    {
        var dict = new Dictionary<string, string>();

        using var conn = new SqlConnection(_connectionString);
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

        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
        IF EXISTS (SELECT 1 FROM ReportStorage WHERE Url = @Url AND IsDefault = 0)
            UPDATE ReportStorage SET ReportLayout = @Layout, UpdatedAt = GETDATE() 
            WHERE Url = @Url AND IsDefault = 0
        ELSE
            INSERT INTO ReportStorage (Url, ReportLayout, IsDefault) 
            VALUES (@Url, @Layout, 0)", conn);

        cmd.Parameters.AddWithValue("@Url", url);
        cmd.Parameters.AddWithValue("@Layout", layoutBytes);
        cmd.ExecuteNonQuery();
    }

    public override string SetNewData(XtraReport report, string defaultUrl)
    {
        if (string.IsNullOrWhiteSpace(defaultUrl) || defaultUrl.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            throw new ArgumentException("Invalid report name");

        using var ms = new MemoryStream();
        report.SaveLayoutToXml(ms);
        var layoutData = ms.ToArray();

        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        using var cmd = new SqlCommand("INSERT INTO ReportStorage (Url, ReportLayout) VALUES (@Url, @Layout)", conn);
        cmd.Parameters.AddWithValue("@Url", defaultUrl);
        cmd.Parameters.AddWithValue("@Layout", layoutData);
        cmd.ExecuteNonQuery();

        return defaultUrl;
    }

}
