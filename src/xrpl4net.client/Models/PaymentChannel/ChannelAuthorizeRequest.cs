using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PaymentChannel
{
    public class ChannelAuthorizeRequest : BaseRequest
    {
        public override string method => "channel_authorize";

        [JsonProperty("params")]
        public ChannelAuthorizeRequestParams Params { get; set; }
    }

    public class ChannelAuthorizeRequestParams : BaseRequestParams
    {
        public string channel_id { get; set; }

        public string secret { get; set; }

        public string seed { get; set; }


        public string seed_hex { get; set; }

        public string passphrase { get; set; }

        public string key_type { get; set; }

        public string amount { get; set; }
    }
}
