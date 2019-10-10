namespace APE.Exposition.Vente.Api.Controllers.Affiliation.Models
{
    public class ReponseCreerAffiliation : BaseReponse
    {
        public int IdentifiantDemandeAffiliation { get; set; }
        public int IdentifiantProjet { get; set; }
    }
}