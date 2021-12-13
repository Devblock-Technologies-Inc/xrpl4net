using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class SubmitRequest : BaseRequest
    {
        public override string method => "submit";

        [JsonProperty("params")]
        public SubmitRequestParams[] Params { get; set; } 
    }

    public class SubmitRequestParams : BaseRequestParams
    {
        public TransactionDefinition tx_json { get; set; }

        public string secret { get; set; }

        public string seed { get; set; }

        public string seed_hex { get; set; }

        public bool offline { get; set; }

        public int fee_mult_max { get; set; }

        public int fee_div_max { get; set; }
    }
}
