using APE.Exposition.Vente.Api.Middlewares;
using APE.Exposition.Vente.Api.Proxies.Affiliation.Adapters;
using APE.Exposition.Vente.Api.Proxies.Authentifier;
using APE.Exposition.Vente.Api.Proxies.Security;
using APE.Exposition.Vente.Api.Proxies.Security.Adapters;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.TokenChecker
{
    public class TokenChecker : ITokenChecker, IDisposable
    {
        private readonly ISecuriteProxy securityClient;
        private readonly IMemoryCache memoryCache;

        public TokenChecker(ISecuriteProxy securityClient, IMemoryCache memoryCache)
        {
            if (securityClient == null)
                throw new ArgumentNullException(nameof(securityClient));
            if (memoryCache == null)
                throw new ArgumentNullException(nameof(memoryCache));

            this.securityClient = securityClient;
            this.memoryCache = memoryCache;
        }

        public async Task<AuthentifierContexte> GetContexteFromDemande(DemandeAuthentifier demande)
        {
            if (demande == null)
                throw new ArgumentNullException(nameof(demande));

            AuthentifierContexte reponseContexte;

            if (memoryCache.TryGetValue(demande.Token, out reponseContexte))
            {
                return await Task.FromResult(reponseContexte).ConfigureAwait(false);
            }
            else
            {
                DemandeObtenirContexte demandeObtenirContexteODV = new DemandeObtenirContexte();
                ReponseObtenirContexte reponseObtenirContexteODV;

                demandeObtenirContexteODV.Token = demande.Token;

                reponseObtenirContexteODV = await securityClient.ObtenirContexteODV(demandeObtenirContexteODV);

                if (reponseObtenirContexteODV == null) return null;

                reponseContexte = new AuthentifierContexte();
                reponseContexte.Token = demande.Token;

                TokenType tokenType;
                if (Enum.TryParse<TokenType>(reponseObtenirContexteODV.TokenType, out tokenType))
                {
                    reponseContexte.TokenType = tokenType;
                }

                memoryCache.Set(demande.Token, reponseContexte, TimeSpan.FromSeconds(Constants.SecondsCacheToken));

                return await Task.FromResult(reponseContexte).ConfigureAwait(false);

            }
        }

        public void Dispose()
        {
            if (memoryCache != null)
                memoryCache.Dispose();
        }
    }
}
