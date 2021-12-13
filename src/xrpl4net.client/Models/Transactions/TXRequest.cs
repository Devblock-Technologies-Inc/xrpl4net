using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TXRequest : BaseRequest
    {
        public override string method => "tx";

        [JsonProperty("params")]
        public TXRequestParams[] Params { get; set; }
    }

    public class TXRequestParams
    {
        public string transaction { get; set; }

        public bool binary { get; set; }

        public int min_ledger { get; set; }

        public int max_ledger { get; set; }
    }
}
