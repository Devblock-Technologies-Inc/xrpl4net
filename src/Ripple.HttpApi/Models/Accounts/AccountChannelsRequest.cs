using Newtonsoft.Json;

namespace Ripple.HttpApi.Models.Accounts
{
    public class AccountChannelsRequest : BaseRequest
    {
        public override string method => "account_channels";

        [JsonProperty("params")]
        public AccountChannelsRequestParams[] Params { get;set;}
    }

    public class AccountChannelsRequestParams
    {
        public string account { get; set; }

        public string destination_account { get; set; }

        public string ledger_index { get; set; }
    }
}
