using Microsoft.AspNetCore.Mvc;
using Ripple.HttpApi.Factories;
using Ripple.HttpApi.Models.Accounts;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Controllers
{
    public class AccountController : BaseController
    {
        #region Fields

        private readonly IAccountModelFactory _accountModelFactory;

        #endregion

        #region Ctor

        public AccountController(IAccountModelFactory accountModelFactory)
        {
            _accountModelFactory = accountModelFactory;
        }

        #endregion

        #region Methods

        [HttpPost]
        [Route("account-channels")]
        public async Task<dynamic> GetAccountChannelAsync(AccountChannelsRequest input)
        {
            var model = await _accountModelFactory.GetAccountChannels(input);
            return model;
        }

        [HttpPost]
        [Route("account-info")]
        public async Task<dynamic> GetAccountInfoAsync(AccountInfoRequest input)
        {
            var model = await _accountModelFactory.GetAccountInfo(input);
            return model;
        }

        [HttpPost]
        [Route("gateway-balances")]
        public async Task<dynamic> GetGatewayBalanceAsync(GatewayBalanceRequest input)
        {
            var model = await _accountModelFactory.GetGatewayBalance(input);
            return model;
        }

        #endregion
    }
}
