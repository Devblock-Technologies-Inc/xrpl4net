using Newtonsoft.Json;

namespace Ripple.HttpApi.Models.Accounts
{
    public class GatewayBalanceRequest : BaseRequest
    {
        public override string method => "gateway_balances";

        [JsonProperty("params")]
        public GatewayBalanceRequestParams[] Params { get; set; }
    }

    public class GatewayBalanceRequestParams
    {
        public string account { get; set; }

        public string[] hotwallet { get; set; }

        public bool strict { get; set; }
    }
}
