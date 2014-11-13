using System;

namespace MPC.Models.DomainModels
{
    public class RegionalSettings
    {
        public int Laguage { get; set; }
        public string LanguageValue { get; set; }
        public string Color { get; set; }
        public string ColorValue { get; set; }
        public string Organization { get; set; }
        public string OrganizationValue { get; set; }
        public string State { get; set; }
        public string StateValue { get; set; }
        public string Centre { get; set; }
        public string CentreValue { get; set; }
        public string ZipCode { get; set; }
        public string ZipCodeValue { get; set; }
        public string Metre { get; set; }
        public string MetreValue { get; set; }
        public string Weight { get; set; }
        public string WeightValue { get; set; }
        public string PaperMeasure { get; set; }
        public string PaperMeasureValue { get; set; }
        public string License { get; set; }
        public string LicenceMeasure { get; set; }
        public short? IsSelected { get; set; }
    }
}
