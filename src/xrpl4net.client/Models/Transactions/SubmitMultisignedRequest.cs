using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class SubmitMultisignedRequest : BaseRequest
    {
        public override string method => "submit_multisigned";

        [JsonProperty("params")]
        public SubmitMultisignedRequestParams[] Params { get; set; }
    }

    public class SubmitMultisignedRequestParams
    {
        public TransactionDefinition tx_json { get; set; }

        public bool fail_hard { get; set; }
    }
}
