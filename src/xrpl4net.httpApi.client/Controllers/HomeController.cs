using Microsoft.AspNetCore.Mvc;

namespace xrpl4net.httpApi.client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/swagger");
        }
    }
}
