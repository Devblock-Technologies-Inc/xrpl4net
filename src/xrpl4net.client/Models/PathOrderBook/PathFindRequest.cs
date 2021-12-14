using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PathOrderBook
{
    public class PathFindRequest : BaseRequest
    {
        public override string method => "path_find";

        [JsonProperty("params")]
        public PathFindRequestParams Params { get; set; }
    }

    public class PathFindRequestParams : BaseRequestParams
    {
        public string subcommand { get; set; }

        public string source_account { get; set; }

        public string destination_account { get; set; }

        public DestinationAmount destination_amount { get; set; }
    }

    public class DestinationAmount
    {
        public string value { get; set; }

        public string currency { get; set; }

        public string issuer { get; set; }
    }
}
