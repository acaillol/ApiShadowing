namespace APE.Exposition.Vente.Api.Configurations
{
    public class ApplicationUrls
    {
        public string DistributionHostUrl { get; set; }

        public string AffiliationBaseUrl { get; set; }

        public WebServicesUrls WebServicesUrls { get; set; }
    }

    public class WebServicesUrls
    {
        public string Securite { get; set; }

        public string Gestion { get; set; }

        public string ServicesReferentielsInformationsPostales { get; set; }
    }
}
