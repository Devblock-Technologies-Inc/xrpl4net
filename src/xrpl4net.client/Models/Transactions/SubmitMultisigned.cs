using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class SubmitMultisigned : BaseRequest
    {
        public override string method => "submit_multisigned";

        [JsonProperty("params")]
        public SubmitMultisignedParams[] Params { get; set; }
    }

    public class SubmitMultisignedParams
    {
        public TransactionDefinition tx_json { get; set; }

        public bool fail_hard { get; set; }
    }
}
