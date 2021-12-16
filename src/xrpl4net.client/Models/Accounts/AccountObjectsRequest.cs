using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountObjectsRequest : BaseRequest
    {
        public override string method => "account_objects";

        [JsonProperty("params")]
        public AccountObjectsRequestParams[] Params { get; set; }
    }

    public class AccountObjectsRequestParams : BaseRequestParams
    {
        public string account { get; set; }

        public string type { get; set; }


        public bool deletion_blockers_only { get; set; }
    }
}
