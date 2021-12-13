using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TransactionEntry : BaseRequest
    {
        public override string method => "transaction_entry";

        [JsonProperty("params")]
        public TransactionEntryParams[] Params { get; set; }
    }

    public class TransactionEntryParams : BaseRequestParams
    {
        public string tx_hash { get; set; }
    }
}
