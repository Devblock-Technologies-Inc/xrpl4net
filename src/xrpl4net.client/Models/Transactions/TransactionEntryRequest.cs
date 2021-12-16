using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TransactionEntryRequest : BaseRequest
    {
        public override string method => "transaction_entry";

        [JsonProperty("params")]
        public TransactionEntryRequestParams[] Params { get; set; }
    }

    public class TransactionEntryRequestParams : BaseRequestParams
    {
        public string tx_hash { get; set; }
    }
}
