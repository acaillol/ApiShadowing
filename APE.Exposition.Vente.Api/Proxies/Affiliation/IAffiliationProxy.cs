using APE.Exposition.Vente.Api.Controllers.Affiliation;
using APE.Exposition.Vente.Api.Controllers.Affiliation.Models;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.Affiliation
{
    public interface IAffiliationProxy
    {
        Task<ReponseCreerAffiliation> CreerDemandeAffiliation(IDemandeCreerAffiliation demande);
    }
}
