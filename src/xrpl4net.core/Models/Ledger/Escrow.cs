using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class Escrow : BaseLedgerEntry  
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "Escrow";

        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        string Destination { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        string Amount { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        string Condition { get; set; }

        [JsonProperty("cancelAfter", NullValueHandling = NullValueHandling.Ignore)]
        double CancelAfter { get; set; }

        [JsonProperty("finishAfter", NullValueHandling = NullValueHandling.Ignore)]
        double FinishAfter { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("sourceTag", NullValueHandling = NullValueHandling.Ignore)]
        double SourceTag { get; set; }

        [JsonProperty("destinationTag", NullValueHandling = NullValueHandling.Ignore)]
        double DestinationTag { get; set; }

        [JsonProperty("ownerNode", NullValueHandling = NullValueHandling.Ignore)]
        string OwnerNode { get; set; }

        [JsonProperty("destinationNode", NullValueHandling = NullValueHandling.Ignore)]
        string DestinationNode { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        double? PreviousTxnLgrSeq { get; set; }
    }
}
