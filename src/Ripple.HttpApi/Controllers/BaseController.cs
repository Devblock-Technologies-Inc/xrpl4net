using Microsoft.AspNetCore.Mvc;

namespace Ripple.HttpApi.Controllers
{
    [ApiController]
    [Route("api/devblock/[controller]")]
    public abstract class BaseController : Controller
    {
    }
}
