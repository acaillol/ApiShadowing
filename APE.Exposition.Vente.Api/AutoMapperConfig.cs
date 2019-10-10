using APE.Exposition.Vente.Api.Controllers.Affiliation.Models;
using APE.Exposition.Vente.Api.Proxies.Security.Adapters;
using AutoMapper;

namespace APE.Exposition.Vente.Api
{
    public static class AutoMapperConfig
    {
        public static void Config()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                ClientMapping(cfg);

                cfg.CreateMap<ServiceGestion.DemandeCreationAffiliation, DemandeCreerAffiliation>();
                cfg.CreateMap<ServiceSecurite.ReponseContexte, ReponseContexte>()
                    .ForMember(dest => dest.IdentiteActive, opt => opt.MapFrom(src => src.Contexte.IdentiteActive))
                    .ForMember(dest => dest.IdentiteConnectee, opt => opt.MapFrom(src => src.Contexte.IdentiteConnectee));
                cfg.CreateMap<ServiceSecurite.ReponseObtenirContexte, ReponseObtenirContexte>();
            });
        }

        private static void ClientMapping(AutoMapper.IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DemandeCreerAffiliation, ServiceGestion.DemandeCreationAffiliation>();
        }

        private class CustomConverter : ITypeConverter<ServiceGestion.DemandeCreationAffiliation, DemandeCreerAffiliation>
        {
            public DemandeCreerAffiliation Convert(ServiceGestion.DemandeCreationAffiliation source, DemandeCreerAffiliation destination, ResolutionContext context)
            {
                return new DemandeCreerAffiliation()
                {
                    IdentifiantTracabilite = source.IdentifiantTracabilite,
                    Nom = source.Nom
                };
            }
        }
    }
}
