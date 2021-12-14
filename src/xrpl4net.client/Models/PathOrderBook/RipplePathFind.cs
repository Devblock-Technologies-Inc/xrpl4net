using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PathOrderBook
{
    public class RipplePathFindRequest : BaseRequest
    {
        public override string method => "ripple_path_find";

        [JsonProperty("params")]
        public RipplePathFindRequestParams Params { get; set; }
    }

    public class RipplePathFindRequestParams : BaseRequestParams
    {
        public string source_account { get; set; }

        public string destination_account { get; set; }

        public DestinationAmount destination_amount { get; set; }

        public SourceCurrency[] source_currencies { get; set; }
    }

    public class SourceCurrency
    {
        public string currency { get; set; }
    }
}
