using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerClosedRequest : BaseRequest
    {
        public override string method => "ledger_closed";

        [JsonProperty("params")]
        public LedgerClosedParams[] Params { get; set; }
    }

    public class LedgerClosedParams
    {
        public string index { get; set; }

        public string ledger_index { get; set; }
    }
}
