using System.Drawing;
using System.Text;

namespace WebApplication1.Data
{
    public class ReportCompanyDTO
    {
        public ReportCompanyDTO(string companyName, string street, string city, string postcode, string countrycode, string countryname, string vat)
        {
            CompanyName = companyName;
            CompanyStreet = street;
            CompanyCityName = city;
            CompanyCityPostCode = postcode;
            CompanyCountryCode = countrycode;
            CompanyCountryName = countryname;
            CompanyVATNumber = vat;

            //if (res.CompanyLogo != null && companyLogo > 0)
            //    using (var ms = new MemoryStream(res.CompanyLogo))
            //    {
            //        CompanyLogo = Image.FromStream(ms);
            //    }
        }

        public string CompanyName { get; set; }
        public string CompanyStreet { get; set; }
        public string CompanyCityName { get; set; }
        public string CompanyCityPostCode { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public string CompanyVATNumber { get; set; }

        public string CompanyTelephone { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyContact { get; set; }

        public Image CompanyLogo { get; set; }

        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(CompanyName);
            sb.AppendLine($"{CompanyStreet} {CompanyCityPostCode} {CompanyCityName} - {CompanyCountryName}");

            if (!string.IsNullOrWhiteSpace(CompanyTelephone) || !string.IsNullOrWhiteSpace(CompanyTelephone))
                sb.AppendLine();
            if (!string.IsNullOrWhiteSpace(CompanyTelephone))
                sb.Append($"Tel: {CompanyTelephone}  ");
            if (!string.IsNullOrWhiteSpace(CompanyFax))
                sb.Append($"Fax: {CompanyFax}");

            sb.AppendLine($"Email: {CompanyEmail}");

            return sb.ToString();
        }
    }
}
