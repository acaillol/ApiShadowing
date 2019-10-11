using APE.Exposition.Vente.Api.Configurations;
using Microsoft.Extensions.Options;
using ServiceSecurite;
using System.ServiceModel;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Proxies.Security
{
    public class SecuriteProxy : ISecuriteProxy
    {
        private ServiceSecurite.ISecurite serviceProxy;

        public SecuriteProxy(IOptions<ApplicationUrls> config)
        {
            if (config == null)
                throw new System.ArgumentNullException(nameof(config));

            BasicHttpBinding binding;
            if (config.Value.WebServicesUrls.Securite.StartsWith("https"))
                binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            else
                binding = new BasicHttpBinding(BasicHttpSecurityMode.None);

            binding.MaxReceivedMessageSize = 1048576; //1Mo
            ChannelFactory<ISecurite> factory = new ChannelFactory<ISecurite>(binding, new EndpointAddress(config.Value.WebServicesUrls.Securite));
            this.serviceProxy = factory.CreateChannel();
        }

        public async Task<Adapters.ReponseObtenirContexte> ObtenirContexteODV(Proxies.Affiliation.Adapters.DemandeObtenirContexte demande)
        {
            DemandeObtenirContexteODV lobj_DemandeObtenirContexteODV = new DemandeObtenirContexteODV();

            lobj_DemandeObtenirContexteODV.Token = demande.Token;

            var contexte = await Task.Run(() => new ServiceSecurite.ReponseObtenirContexte() { TokenType = "SSO" });

            var mappedContexte = AutoMapper.Mapper.Map<Adapters.ReponseObtenirContexte>(contexte);

            return mappedContexte;
        }
    }
}
