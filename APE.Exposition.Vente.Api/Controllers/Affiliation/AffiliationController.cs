using APE.Exposition.Vente.Api.Controllers.Affiliation.Models;
using APE.Exposition.Vente.Api.Services.Affiliation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Controllers.Affiliation
{
    [Produces("application/json")]
    [Route("api/affil")]
    public class AffiliationController : BaseController
    {
        private readonly RequestCache requestCache;
        private readonly AffiliationCreationService affiliationCreationService;

        public AffiliationController(RequestCache requestCache, AffiliationCreationService affiliationCreationService) : base(requestCache)
        {
            this.requestCache = requestCache;
            this.affiliationCreationService = affiliationCreationService;
        }

        [HttpPost]
        [Route("creer")]
        public async Task<ReponseCreerAffiliation> CreerAffiliation([FromBody]DemandeCreerAffiliation demande)
        {
            demande.IdentifiantTracabilite = HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            ReponseCreerAffiliation result = new ReponseCreerAffiliation();

            try
            {
                result = await affiliationCreationService.CreerDemandeAffiliation(demande);
            }
            catch (Exception ex)
            {
                result.MessageTechnique = ex.Message;
            }

            return result;
        }
    }
}