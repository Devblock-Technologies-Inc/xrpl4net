using Microsoft.AspNetCore.Mvc;

namespace Ripple.HttpApi.Controllers
{
    [ApiController]
    [Route("api/onesign/[controller]")]
    public abstract class BaseController : Controller
    {
    }
}
