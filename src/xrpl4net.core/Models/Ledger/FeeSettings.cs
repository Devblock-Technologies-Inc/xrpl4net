using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class FeeSettings : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "FeeSettings";

        [JsonProperty("baseFee", NullValueHandling = NullValueHandling.Ignore)]
        string BaseFee { get; set; }

        [JsonProperty("referenceFeeUnits", NullValueHandling = NullValueHandling.Ignore)]
        double ReferenceFeeUnits { get; set; }

        [JsonProperty("reserveBase", NullValueHandling = NullValueHandling.Ignore)]
        double ReserveBase { get; set; }

        [JsonProperty("reserveIncrement", NullValueHandling = NullValueHandling.Ignore)]
        double ReserveIncrement { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }
    }
}
