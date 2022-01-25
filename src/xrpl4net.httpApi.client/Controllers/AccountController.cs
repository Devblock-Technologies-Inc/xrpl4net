using Microsoft.AspNetCore.Mvc;
using Ripple.Signing;
using System.Threading.Tasks;
using Xrpl4net.Client;
using Xrpl4net.Client.Models.Faucet;

namespace xrpl4net.httpApi.client.Controllers
{
    public class AccountController : BaseApiController
    {
        #region Ctor

        public AccountController()
        {

        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<FaucetAccountResponse> GetAccountCredentails(string encodedSeed)
        {
            var seed = string.IsNullOrEmpty(encodedSeed) ? Seed.FromBase58(encodedSeed) : Seed.FromRandom();
            var pair = seed.KeyPair();
            var classicAddress = pair.Id();
            var fundAccountRequest = new FundAccountRequest
            {
                destination = classicAddress
            };
            var fundAccountResponse = await _faucetClient.FundAccount(fundAccountRequest);
            return fundAccountResponse;
        }

        #endregion
    }
}
