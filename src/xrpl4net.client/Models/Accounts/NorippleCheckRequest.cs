using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Accounts
{
    public class NorippleCheckRequest : BaseRequest
    {
        public override string method => "account_offers";

        [JsonProperty("params")]
        public NorippleCheckRequestParams[] Params { get; set; }
    }

    public class NorippleCheckRequestParams
    {
        public string account { get; set; }

        public string role { get; set; }

        public string ledger_index { get; set; }

        public bool transactions { get; set; }
    }
}
