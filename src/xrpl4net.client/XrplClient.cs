using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Http;
using Xrpl4net.Client.Models;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.Ledger;

namespace Xrpl4net.Client
{
    public class XrplClient
    {
        #region Fields

        private readonly string _uri;
        private HttpClient _httpClient;

        #endregion

        #region Ctor

        public XrplClient(string uri)
        {
            _uri = uri;
            _httpClient = new HttpClient();
        }

        #endregion

        #region Methods

        public async Task<dynamic> GetAccountChannels(AccountChannelsRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountInfo(AccountInfoRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetGatewayBalance(GatewayBalanceRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountCurrencies(AccountCurrenciesRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountLines(AccountLinesRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountObjects(AccountObjectsRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountOffers(AccountOffersRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetAccountTX(AccountTXRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetNorippleCheck(NorippleCheckRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetLedger(LedgerRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetLedgerEntryRequest(LedgerEntryRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetLedgerClosed(LedgerClosedRequest input)
        {
            return await GetJsonFromContent(input);
        }

        public async Task<dynamic> GetLedgerCurrent(LedgerCurrentRequest input)
        {
            return await GetJsonFromContent(input);
        }

        #endregion

        #region Utils

        private async Task<dynamic> GetJsonFromContent<T>(T input) where T : BaseRequest
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpClientExtensions.PostJsonContent(_uri, _httpClient, request);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            return result;
        }

        #endregion
    }
}
