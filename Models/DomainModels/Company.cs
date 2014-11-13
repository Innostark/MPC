using System;

namespace MPC.Models.DomainModels
{
    /// <summary>
    /// Company
    /// </summary>
    public sealed class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteLogo { get; set; }
        public string MISLogo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public int? Country { get; set; }
        public string ZipCode { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string RegNo { get; set; }
        public string TaxNo { get; set; }
        public string TaxName { get; set; }
        public string Language { get; set; }
        public byte[] CostCentreDLL { get; set; }
        public DateTime? CostCentreUpdationDate { get; set; }
    }
}

