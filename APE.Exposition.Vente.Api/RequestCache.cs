using APE.Exposition.Vente.Api.Proxies.Authentifier;
using System.Collections.Generic;

namespace APE.Exposition.Vente.Api
{
    public class RequestCache
    {
        private IDictionary<string, AuthentifierContexte> cacheDictionary = new Dictionary<string, AuthentifierContexte>();

        public AuthentifierContexte SecurityContexte
        {
            get
            {
                return cacheDictionary[Constants.SecurityContextKey];
            }
            set
            {
                cacheDictionary.Add(Constants.SecurityContextKey, value);
            }
        }
    }
}
