using APE.Exposition.Vente.Api.Middlewares;

namespace APE.Exposition.Vente.Api.Proxies.Authentifier
{
    public class AuthentifierContexte
    {
        public TokenType TokenType { get; set; }

        public string Token { get; set; } = null;

        internal enum StatutMetierResults
        {
            SUCCES,
            ECHEC
        }
    }
}