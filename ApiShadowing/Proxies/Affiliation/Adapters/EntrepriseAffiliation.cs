using Newtonsoft.Json;

namespace APE.Exposition.Vente.Api.Proxies.Affiliation.Adapters
{
    public class EntrepriseAffiliation
    {
        public string NumEtablissement { get; set; }
        [JsonProperty("raisonSociale")]
        public string RaisonSocialeEtablissement { get; set; }
        public string IdentifiantDADH { get; set; }
        public string CodeCourtier { get; set; }
    }
}
