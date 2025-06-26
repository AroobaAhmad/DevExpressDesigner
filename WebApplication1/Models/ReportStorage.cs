using System;

namespace WebApplication1.Models
{
    public class ReportStorage
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public byte[] ReportLayout { get; set; } = Array.Empty<byte>();
        public bool IsDefault { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}