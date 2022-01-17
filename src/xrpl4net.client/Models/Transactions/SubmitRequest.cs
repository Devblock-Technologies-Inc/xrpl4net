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

        public string tx_blob { get; set; }
    }
}
