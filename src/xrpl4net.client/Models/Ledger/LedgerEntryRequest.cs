using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerEntryRequest : BaseRequest
    {
        public override string method => "ledger_entry";

        [JsonProperty("params")]
        public LedgerEntryRequestParams[] Params { get; set; }
    }

    public class LedgerEntryRequestParams
    {
        public string index { get; set; }   

        public string ledger_index { get; set; }
    }
}
