using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class Check : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "Check";

        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        string Destination { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        bool Flags { get; set; }

        [JsonProperty("ownerNode", NullValueHandling = NullValueHandling.Ignore)]
        string OwnerNode { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnLgrSeq { get; set; }

        [JsonProperty("sendMax", NullValueHandling = NullValueHandling.Ignore)]
        Amount SendMax { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        double Sequence { get; set; }

        [JsonProperty("destinationNode", NullValueHandling = NullValueHandling.Ignore)]
        string DestinationNode { get; set; }

        [JsonProperty("destinationTag", NullValueHandling = NullValueHandling.Ignore)]
        double DestinationTag { get; set; }

        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        double Expiration { get; set; }

        [JsonProperty("invoiceID", NullValueHandling = NullValueHandling.Ignore)]
        string InvoiceID { get; set; }

        [JsonProperty("sourceTag", NullValueHandling = NullValueHandling.Ignore)]
        double SourceTag { get; set; }
    }
}
