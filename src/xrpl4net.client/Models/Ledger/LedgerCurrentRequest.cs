using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerCurrentRequest : BaseRequest
    {
        public override string method => "ledger_current";

        [JsonProperty("params")]
        public LedgerCurrentParams[] Params { get; set; }
    }

    public class LedgerCurrentParams
    {
        public string ledger_current_index { get; set; }
    }
}
