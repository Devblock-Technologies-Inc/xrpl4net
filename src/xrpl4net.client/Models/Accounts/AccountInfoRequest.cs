using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountInfoRequest : BaseRequest
    {
        public override string method => "account_info";

        [JsonProperty("params")]
        public AccountInfoRequestParams[] Params { get; set; }
    }

    public class AccountInfoRequestParams
    {
        public string account { get; set; }

        public bool strict { get; set; }

        public bool queue { get; set; }

        public string ledger_index { get; set; }
    }
}
