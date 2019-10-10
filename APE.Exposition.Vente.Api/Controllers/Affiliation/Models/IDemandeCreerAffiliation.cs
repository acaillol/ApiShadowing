namespace APE.Exposition.Vente.Api.Controllers.Affiliation.Models
{
    public interface IDemandeCreerAffiliation : IDemandeValidator
    {
        string Nom { get; set; }
    }
}