using APE.Exposition.Vente.Api.Proxies.TokenChecker;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace APE.Exposition.Vente.Api.Middlewares
{
    public class CheckTokenMiddleware
    {
        private readonly RequestDelegate next;
        private ITokenChecker tokenChecker;
        private RequestCache requestCache;
        private const string TOKEN_NAME = "token";

        public CheckTokenMiddleware(RequestDelegate next, ITokenChecker tokenChecker/*, RequestCache requestCache*/)
        {
            this.next = next;
            this.tokenChecker = tokenChecker;
            //this.requestCache = requestCache;
        }

        public async Task Invoke(HttpContext httpContext, RequestCache requestCache)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (!httpContext.Request.Headers.ContainsKey(TOKEN_NAME) || string.IsNullOrEmpty(httpContext.Request.Headers[TOKEN_NAME]))
            {
                httpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.Forbidden;
                return;
            }

            string token = httpContext.Request.Headers[TOKEN_NAME].ToString();
            var demande = new DemandeAuthentifier(httpContext.Connection.RemoteIpAddress.MapToIPv4().ToString(), token);
            try
            {
                if (token == "THROW")
                    throw new Exception("Exception de test");

                var reponseContexte = await tokenChecker.GetContexteFromDemande(demande);

                if (reponseContexte == null || token == "FAIL")
                {
                    httpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.Forbidden;
                    return;
                }
                else
                {
                    requestCache.SecurityContexte = reponseContexte;
                    await next.Invoke(httpContext);
                }
            }
            catch
            {
                httpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.ServiceUnavailable;
                return;
            }
        }
    }
}
