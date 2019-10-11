namespace APE.Exposition.Vente.Api.Controllers.Affiliation.Models
{
    public class DemandeCreerAffiliation : BaseDemande, IDemandeCreerAffiliation
    {
        public string Nom { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrEmpty(Nom))
                    return false;

                return true;
            }
        }
    }
}