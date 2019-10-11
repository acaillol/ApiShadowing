using APE.Exposition.Vente.Api.Configurations;
using APE.Exposition.Vente.Api.Proxies.Affiliation;
using APE.Exposition.Vente.Api.Proxies.Security;
using Microsoft.Extensions.Options;
using System;

namespace APE.Exposition.Vente.Api.Services.Affiliation
{
    public abstract class AffiliationServiceBase
    {
        protected IAffiliationProxy affiliationClient;
        private ISecuriteProxy securiteProxy;
        private readonly IOptions<ApplicationUrls> applicationUrls;

        const string url = "{0}/#/c={1}&j={2}";

        public AffiliationServiceBase(IAffiliationProxy affiliationProxy, ISecuriteProxy securiteProxy, IOptions<ApplicationUrls> config)
        {
            this.affiliationClient = affiliationProxy ?? throw new ArgumentNullException(nameof(affiliationProxy));
            this.securiteProxy = securiteProxy ?? throw new ArgumentNullException(nameof(securiteProxy));
            this.applicationUrls = config ?? throw new ArgumentNullException(nameof(config));
        }
    }
}
