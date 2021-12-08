using Microsoft.AspNetCore.Mvc;

namespace Ripple.HttpApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/swagger");
        }
    }
}
