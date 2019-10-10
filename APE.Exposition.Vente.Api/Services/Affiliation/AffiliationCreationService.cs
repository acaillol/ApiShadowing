using APE.Exposition.Vente.Api.Configurations;
using APE.Exposition.Vente.Api.Controllers.Affiliation;
using APE.Exposition.Vente.Api.Controllers.Affiliation.Models;
using APE.Exposition.Vente.Api.Proxies.Affiliation;
using APE.Exposition.Vente.Api.Proxies.Security;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Services.Affiliation
{
    public class AffiliationCreationService : AffiliationServiceBase
    {
        public AffiliationCreationService(IAffiliationProxy affiliationProxy, ISecuriteProxy securiteProxy, IOptions<ApplicationUrls> config)
            : base(affiliationProxy, securiteProxy, config)
        { }

        internal async Task<ReponseCreerAffiliation> CreerDemandeAffiliation(IDemandeCreerAffiliation demande)
        {
            if (demande == null)
                throw new ArgumentNullException(nameof(demande));

            if (!demande.IsValid)
                throw new InvalidOperationException("L'objet n'est pas correctement initialisé.");

            ReponseCreerAffiliation reponse = await affiliationClient.CreerDemandeAffiliation(demande);

            return reponse;
        }
    }
}
