using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class Majority
    {
        [JsonProperty("amendment", NullValueHandling = NullValueHandling.Ignore)]
        string Amendment { get; set; }

        [JsonProperty("closeTime", NullValueHandling = NullValueHandling.Ignore)]
        double CloseTime { get; set; }
    }

    class Amendment : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "Amendments";

        [JsonProperty("amendments", NullValueHandling = NullValueHandling.Ignore)]
        string[] Amendments { get; set; }

        [JsonProperty("majorities", NullValueHandling = NullValueHandling.Ignore)]
        Majority[] Majorities { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        bool Flags { get; set; }
    }
}
