using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerRequest : BaseRequest
    {
        public override string method => "ledger";

        [JsonProperty("params")]
        public LedgerRequestParams[] Params { get; set; }
    }

    public class LedgerRequestParams
    {
        public bool accounts { get; set; }

        public bool full { get; set; }

        public bool transactions { get; set; }

        public bool expand { get; set; }

        public bool owner_funds { get; set; }

        public string ledger_index { get; set; }
    }
}
