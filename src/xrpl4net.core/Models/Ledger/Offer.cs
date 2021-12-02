using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class Offer : BaseLedgerEntry
    {
        [JsonProperty("LedgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "Offer";

        [JsonProperty("Flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("Sequence", NullValueHandling = NullValueHandling.Ignore)]
        double Sequence { get; set; }

        [JsonProperty("TakerPays", NullValueHandling = NullValueHandling.Ignore)]
        Amount TakerPays { get; set; }

        [JsonProperty("TakerGets", NullValueHandling = NullValueHandling.Ignore)]
        Amount TakerGets { get; set; }

        [JsonProperty("bookDirectory", NullValueHandling = NullValueHandling.Ignore)]
        string BookDirectory { get; set; }

        [JsonProperty("bookNode", NullValueHandling = NullValueHandling.Ignore)]
        string BookNode { get; set; }

        [JsonProperty("ownerNode", NullValueHandling = NullValueHandling.Ignore)]
        string OwnerNode { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        double PreviousTxnLgrSeq { get; set; }

        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        double? Expiration { get; set; }
    }

    enum OfferFlags
    {
        LsfPassive = 0x00010000,
        LsfSell = 0x00020000,
    }
}
