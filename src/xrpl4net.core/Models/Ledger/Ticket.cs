using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class Ticket : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "Ticket";

        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("ownerNode", NullValueHandling = NullValueHandling.Ignore)]
        string OwnerNode { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        double PreviousTxnID { get; set; }

        [JsonProperty("ticketSequence", NullValueHandling = NullValueHandling.Ignore)]
        double TicketSequence { get; set; }

    }
}
