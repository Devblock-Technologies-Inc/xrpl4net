using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.KeyGeneration
{
    public class WalletProposeRequest : BaseRequest
    {
        public override string method => "wallet_propose";

        [JsonProperty("params")]
        public WalletProposeRequestParams[] Params { get; set; }
    }

    public class WalletProposeRequestParams
    {
        public string key_type { get; set; }

        public string seed { get; set; }
    }
}
