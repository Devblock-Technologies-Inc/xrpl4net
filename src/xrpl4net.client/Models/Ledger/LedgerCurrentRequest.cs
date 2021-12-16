using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerCurrentRequest : BaseRequest
    {
        public override string method => "ledger_current";

        [JsonProperty("params")]
        public LedgerCurrentRequestParams[] Params { get; set; }
    }

    public class LedgerCurrentRequestParams
    {
    }
}
