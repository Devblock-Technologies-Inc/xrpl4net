using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Accounts
{

    public class AccountOffersRequest : BaseRequest
    {
        public override string method => "account_offers";

        [JsonProperty("params")]
        public AccountOffersRequestParams[] Params { get; set; }
    }

    public class AccountOffersRequestParams
    {
        public string account { get; set; }

        public string ledger_hash { get; set; }

        public bool strict { get; set; }
    }
}
