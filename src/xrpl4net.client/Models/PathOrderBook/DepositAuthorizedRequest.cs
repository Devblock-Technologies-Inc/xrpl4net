using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PathOrderBook
{
    public class DepositAuthorizedRequest : BaseRequest
    {
        public override string method => "deposit_authorized";

        [JsonProperty("params")]
        public DepositAuthorizedRequestParams[] Params { get; set; }
    }

    public class DepositAuthorizedRequestParams : BaseRequestParams
    {
        public string source_account { get; set; }

        public string destination_account { get; set; }
    }
}
