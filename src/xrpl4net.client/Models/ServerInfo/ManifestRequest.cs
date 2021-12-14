using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.ServerInfo
{
    public class ManifestRequest : BaseRequest
    {
        public override string method => "manifest";

        [JsonProperty("params")]
        public ManifestRequestParams Params { get; set; }
    }

    public class ManifestRequestParams : BaseRequestParams
    {
        public string public_key { get; set; }
    }
}
