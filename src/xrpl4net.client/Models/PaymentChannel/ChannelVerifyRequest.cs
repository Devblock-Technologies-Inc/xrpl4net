using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PaymentChannel
{
    public class ChannelVerifyRequest : BaseRequest
    {
        public override string method => "channel_verify";

        [JsonProperty("params")]
        public ChannelVerifyRequestParams Params { get; set; }
    }

    public class ChannelVerifyRequestParams : BaseRequestParams
    {
        public string amount { get; set; }

        public string signature { get; set; }

        public string public_key { get; set; }

        public string channel_id { get; set; }
    }
}
