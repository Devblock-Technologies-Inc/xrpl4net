using Microsoft.AspNetCore.Mvc;
using Ripple.Signing;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xrpl4net.Client;
using Xrpl4net.Client.Models.Accounts;
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
        [Route("get-credentails")]
        public async Task<FaucetAccountResponse> GetAccountCredentails()
        {
            var seed = Seed.FromRandom();
            var pair = seed.KeyPair();
            var classicAddress = pair.Id();
            var fundAccountRequest = new FundAccountRequest
            {
                destination = classicAddress
            };
            var fundAccountResponse = await _faucetClient.FundAccount(fundAccountRequest);
            fundAccountResponse.secret = seed.ToString();
            return fundAccountResponse;
        }

        [HttpGet]
        public async Task<AccountInfoResponse> GetAccountInfo(string classicAddress)
        {
            var accountInfoRequest = new AccountInfoRequest
            {
                Params = new List<AccountInfoRequestParams>
                {
                    new AccountInfoRequestParams
                    {
                        account = classicAddress,
                        strict = true,
                        ledger_index = "current",
                        queue = true
                    }
                }.ToArray()
            };

            return await _xrplClient.AccountInfo(accountInfoRequest);
        }

        #endregion
    }
}
