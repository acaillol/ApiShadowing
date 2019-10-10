using APE.Exposition.Vente.Api.Proxies.TokenChecker;
using System;

namespace APE.Exposition.Vente.Api.Middlewares
{
    public class DemandeAuthentifier : DemandeBaseToken
    {
        public DemandeAuthentifier(string ipAddress, string token)
        {
            if (string.IsNullOrEmpty(ipAddress))
                throw new ArgumentNullException(nameof(ipAddress));

            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token));

            Token = token;
        }
    }
}
