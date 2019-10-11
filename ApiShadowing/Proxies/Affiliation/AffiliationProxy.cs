using APE.Exposition.Vente.Api.Configurations;
using APE.Exposition.Vente.Api.Controllers.Affiliation;
using APE.Exposition.Vente.Api.Controllers.Affiliation.Models;
using Microsoft.Extensions.Options;
using ServiceGestion;
using System.ServiceModel;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.Affiliation
{
    public class AffiliationProxy : IAffiliationProxy
    {
        private IGestion gestionProxy;

        public AffiliationProxy(IOptions<ApplicationUrls> config)
        {
            if (config == null)
                throw new System.ArgumentNullException(nameof(config));

            BasicHttpBinding binding;
            if (config.Value.WebServicesUrls.Gestion.StartsWith("https"))
                binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            else
                binding = new BasicHttpBinding(BasicHttpSecurityMode.None);

            binding.MaxReceivedMessageSize = 4194304; //4Mo
            ChannelFactory<IGestion> factory = new ChannelFactory<IGestion>(binding, new EndpointAddress(config.Value.WebServicesUrls.Gestion));
            this.gestionProxy = factory.CreateChannel();
        }

        public async Task<ReponseCreerAffiliation> CreerDemandeAffiliation(IDemandeCreerAffiliation demande)
        {
            var demandeGestion = AutoMapper.Mapper.Map<DemandeCreationAffiliation>(demande);

            var responseClient = await Task.Run(() => new ReponseCreerAffiliation() { IdentifiantDemandeAffiliation = 123456789 });

            var reponse = AutoMapper.Mapper.Map<ReponseCreerAffiliation>(responseClient);

            return reponse;
        }
    }
}
