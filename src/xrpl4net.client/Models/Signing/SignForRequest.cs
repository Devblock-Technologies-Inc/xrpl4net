using Newtonsoft.Json;
using Xrpl4net.Client.Models.Transactions;

namespace Xrpl4net.Client.Models.Signing
{
    public class SignForRequest : BaseRequest
    {
        public override string method => "sign_for";

        [JsonProperty("params")]
        public SignForRequestParams Params { get; set; }
    }

    public class SignForRequestParams
    {
        public TransactionDefinition tx_json { get; set; }

        public string account { get; set; }

        public string seed { get; set; }

        public string key_type { get; set; }

        public string secret { get; set; }
    }
}
