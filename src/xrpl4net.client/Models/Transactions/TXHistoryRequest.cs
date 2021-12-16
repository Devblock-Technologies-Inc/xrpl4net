using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TXHistoryRequest : BaseRequest
    {
        public override string method => "tx_history";

        [JsonProperty("params")]
        public TXHistoryParams[] Params { get; set; }
    }

    public class TXHistoryParams
    {
        public int start { get; set; }

        public string index { get; set; }

    }
}
