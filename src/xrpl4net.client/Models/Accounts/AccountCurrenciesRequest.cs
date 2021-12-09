using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountCurrenciesRequest : BaseRequest
    {
        public override string method => "account_currencies";

        [JsonProperty("params")]
        public AccountCurrenciesRequestParams[] Params { get; set; }
    }

    public class AccountCurrenciesRequestParams
    {
        public string account { get; set; }

        public string ledger_hash { get; set; }

        public bool strict { get; set; }
    }
}
