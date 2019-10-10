using APE.Exposition.Vente.Api.Proxies.Affiliation.Adapters;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.Security
{
    public interface ISecuriteProxy
    {
        Task<Adapters.ReponseObtenirContexte> ObtenirContexteODV(DemandeObtenirContexte demande);
    }
}