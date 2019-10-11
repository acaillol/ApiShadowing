using APE.Exposition.Vente.Api.Middlewares;
using APE.Exposition.Vente.Api.Proxies.Authentifier;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.TokenChecker
{
    public interface ITokenChecker
    {
        Task<AuthentifierContexte> GetContexteFromDemande(DemandeAuthentifier demande);
    }
}