using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xrpl4net.Client.Http;
using Xrpl4net.Client.Models;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.Ledger;
using Xrpl4net.Client.Models.PathOrderBook;
using Xrpl4net.Client.Models.PaymentChannel;
using Xrpl4net.Client.Models.ServerInfo;
using Xrpl4net.Client.Models.Transactions;

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

        public async Task<AccountChannelsResponse> AccountChannels(AccountChannelsRequest input)
        {
            return await GetJsonFromContent<AccountChannelsRequest, AccountChannelsResponse>(input);
        }

        public async Task<AccountInfoResponse> AccountInfo(AccountInfoRequest input)
        {
            return await GetJsonFromContent<AccountInfoRequest, AccountInfoResponse>(input);
        }

        public async Task<GatewayBalanceResponse> GatewayBalance(GatewayBalanceRequest input)
        {
            return await GetJsonFromContent<GatewayBalanceRequest, GatewayBalanceResponse>(input);
        }

        public async Task<AccountCurrenciesResponse> AccountCurrencies(AccountCurrenciesRequest input)
        {
            return await GetJsonFromContent<AccountCurrenciesRequest, AccountCurrenciesResponse>(input);
        }

        public async Task<AccountLinesResponse> AccountLines(AccountLinesRequest input)
        {
            return await GetJsonFromContent<AccountLinesRequest, AccountLinesResponse>(input);
        }

        public async Task<AccountObjectsResponse> AccountObjects(AccountObjectsRequest input)
        {
            return await GetJsonFromContent<AccountObjectsRequest, AccountObjectsResponse>(input);
        }

        public async Task<AccountOffersResponse> AccountOffers(AccountOffersRequest input)
        {
            return await GetJsonFromContent<AccountOffersRequest, AccountOffersResponse>(input);
        }

        public async Task<AccountTXResponse> AccountTX(AccountTXRequest input)
        {
            return await GetJsonFromContent<AccountTXRequest, AccountTXResponse>(input);
        }

        public async Task<NoRippleCheckResponse> NorippleCheck(NorippleCheckRequest input)
        {
            return await GetJsonFromContent<NorippleCheckRequest, NoRippleCheckResponse>(input);
        }

        public async Task<LedgerResponse> Ledger(LedgerRequest input)
        {
            return await GetJsonFromContent<LedgerRequest, LedgerResponse>(input);
        }

        public async Task<LedgerEntryResponse> LedgerEntryRequest(LedgerEntryRequest input)
        {
            return await GetJsonFromContent<LedgerEntryRequest, LedgerEntryResponse>(input);
        }

        public async Task<LedgerClosedResponse> LedgerClosed(LedgerClosedRequest input)
        {
            return await GetJsonFromContent<LedgerClosedRequest, LedgerClosedResponse>(input);
        }

        public async Task<LedgerCurrentResponse> LedgerCurrent(LedgerCurrentRequest input)
        {
            return await GetJsonFromContent<LedgerCurrentRequest, LedgerCurrentResponse>(input);
        }

        public async Task<LedgerDataResponse> LedgerData(LedgerDataResquest input)
        {
            return await GetJsonFromContent<LedgerDataResquest, LedgerDataResponse>(input);
        }

        public async Task<SubmitResponse> Submit(SubmitRequest input)
        {
            return await GetJsonFromContent<SubmitRequest, SubmitResponse>(input);
        }

        public async Task<SubmitMultisignedResponse> SubmitMultisigned(SubmitMultisignedRequest input)
        {
            return await GetJsonFromContent<SubmitMultisignedRequest, SubmitMultisignedResponse>(input);
        }

        public async Task<TXResponse> TXRequest(TXRequest input)
        {
            return await GetJsonFromContent<TXRequest, TXResponse>(input);
        }

        public async Task<TXHistoryResponse> TXHistory(TXHistoryRequest input)
        {
            return await GetJsonFromContent<TXHistoryRequest, TXHistoryResponse>(input);
        }

        public async Task<BookOffersResponse> BookOffers(BookOffersRequest input)
        {
            return await GetJsonFromContent<BookOffersRequest, BookOffersResponse>(input);
        }

        public async Task<DepositAuthorizedResponse> DepositAuthorized(DepositAuthorizedRequest input)
        {
            return await GetJsonFromContent<DepositAuthorizedRequest, DepositAuthorizedResponse>(input);
        }

        public async Task<PathFindResponse> PathFind(PathFindRequest input)
        {
            return await GetJsonFromContent<PathFindRequest, PathFindResponse>(input);
        }

        public async Task<RipplePathFindResponse> RipplePathFind(RipplePathFindRequest input)
        {
            return await GetJsonFromContent<RipplePathFindRequest, RipplePathFindResponse>(input);
        }

        public async Task<ChannelAuthorizeResponse> ChannelAuthorize(ChannelAuthorizeRequest input)
        {
            return await GetJsonFromContent<ChannelAuthorizeRequest, ChannelAuthorizeResponse>(input);
        }

        public async Task<ChannelVerifyResponse> ChannelVerify(ChannelVerifyRequest input)
        {
            return await GetJsonFromContent<ChannelVerifyRequest, ChannelVerifyResponse>(input);
        }

        public async Task<FeeResponse> Fee(FeeRequest input)
        {
            return await GetJsonFromContent<FeeRequest, FeeResponse>(input);
        }

        public async Task<ManifestResponse> Manifest(ManifestRequest input)
        {
            return await GetJsonFromContent<ManifestRequest, ManifestResponse>(input);
        }

        public async Task<ServerInfoResponse> ServerInfo(ServerInfoRequest input)
        {
            return await GetJsonFromContent<ServerInfoRequest, ServerInfoResponse>(input);
        }

        public async Task<ServerStateResponse> ServerState(ServerStateRequest input)
        {
            return await GetJsonFromContent<ServerStateRequest, ServerStateResponse>(input);
        }

        #endregion

        #region Utils

        private async Task<Tm> GetJsonFromContent<T, Tm>(T input)
            where T : BaseRequest
            where Tm : class
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpClientExtensions.PostJsonContent(_httpClient, _uri, request);
            var result = JsonConvert.DeserializeObject<Tm>(response);

            return result;
        }

        #endregion
    }
}
