using System.Collections.Generic;

namespace APE.Exposition.Vente.Api.Controllers
{
    public class BaseReponse
    {
        public string StatutTechnique { get; set; }

        public string MessageTechnique { get; set; }

        public string StatutMetier { get; set; }

        public List<string> MessagesMetier { get; set; }
    }
}
