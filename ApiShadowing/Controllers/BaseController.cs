using Microsoft.AspNetCore.Mvc;

namespace APE.Exposition.Vente.Api.Controllers
{
    public class BaseController : Controller
    {
        public RequestCache RequestCache { get; }

        public BaseController(RequestCache requestCache)
        {
            this.RequestCache = requestCache;
        }
    }
}
