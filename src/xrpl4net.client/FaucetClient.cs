using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Http;
using Xrpl4net.Client.Models.Faucet;

namespace Xrpl4net.Client
{
    public class FaucetClient
    {
        #region Fields

        private readonly string _uri;
        private HttpClient _httpClient;

        #endregion

        #region Ctor

        public FaucetClient(string uri)
        {
            _uri = uri;
            _httpClient = new HttpClient();
        }

        #endregion

        #region Methods

        public async Task<FaucetAccountResponse> FundAccount(FundAccountRequest input)
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await _httpClient.PostJsonContent($"{_uri}/accounts", request);
            var result = JsonConvert.DeserializeObject<FaucetAccountResponse>(response);
            return result;
        }

        #endregion
    }
}
