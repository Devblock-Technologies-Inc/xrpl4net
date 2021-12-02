using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class RippleState
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "RippleState";

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        IssuedCurrencyAmount Balance { get; set; }

        [JsonProperty("lowLimit", NullValueHandling = NullValueHandling.Ignore)]
        IssuedCurrencyAmount LowLimit { get; set; }

        [JsonProperty("highLimit", NullValueHandling = NullValueHandling.Ignore)]
        IssuedCurrencyAmount HighLimit { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        double PreviousTxnLgrSeq { get; set; }

        [JsonProperty("lowNode", NullValueHandling = NullValueHandling.Ignore)]
        string LowNode { get; set; }

        [JsonProperty("highNode", NullValueHandling = NullValueHandling.Ignore)]
        string HighNode { get; set; }

        [JsonProperty("lowQualityIn", NullValueHandling = NullValueHandling.Ignore)]
        double? LowQualityIn { get; set; }

        [JsonProperty("lowQualityOut", NullValueHandling = NullValueHandling.Ignore)]
        double? LowQualityOut { get; set; }

        [JsonProperty("highQualityIn", NullValueHandling = NullValueHandling.Ignore)]
        double? HighQualityIn { get; set; }

        [JsonProperty("highQualityOut", NullValueHandling = NullValueHandling.Ignore)]
        double? HighQualityOut { get; set; }

    }

    enum RippleStateFlags
    {
        // True, if entry counts toward reserve.
        LsfLowReserve = 0x00010000,
        LsfHighReserve = 0x00020000,
        LsfLowAuth = 0x00040000,
        LsfHighAuth = 0x00080000,
        LsfLowNoRipple = 0x00100000,
        LsfHighNoRipple = 0x00200000,
        // True, low side has set freeze flag
        LsfLowFreeze = 0x00400000,
        // True, high side has set freeze flag
        LsfHighFreeze = 0x00800000,
    }
}
