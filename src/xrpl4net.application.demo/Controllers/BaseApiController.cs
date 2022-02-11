using Microsoft.AspNetCore.Mvc;
using Xrpl4net.Client;

namespace xrpl4net.application.demo.Controllers
{
    public abstract class BaseApiController : Controller
    {
        #region Fields

        protected XrplClient _xrplClient;
        protected FaucetClient _faucetClient;

        #endregion

        #region Ctor

        public BaseApiController()
        {
            _xrplClient = new XrplClient("https://s.altnet.rippletest.net:51234/");
            _faucetClient = new FaucetClient("https://faucet.altnet.rippletest.net");
        }

        #endregion
    }
}
