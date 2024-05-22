
namespace FinalPojects.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string? ProductType { get; set; }
        public string? ScientificName { get; set; }
        public string? TradName { get; set; }
        public string? PharmaceuticalForm { get; set; }
        public string? HowToUse { get; set; }
        public string? SizeUnit { get; set; }
        public string? PackageType { get; set; }
        public int PackageSize { get; set; }
        public string? LegalStatus { get; set; }
        public string? DistributeArea { get; set; }
        public float PublicPrice { get; set; }
        public string? StorageConditions { get; set; }
        public string? MarktingCountry { get; set; }
        public string? MainAgent { get; set; }
        public int DescriptionCode { get; set; }

    }
}
