namespace Xrpl4net.Core
{
    class RippleState
    {
        string LedgerEntryType => "RippleState";

        double Flags { get; set; }

        IssuedCurrencyAmount Balance { get; set; }

        IssuedCurrencyAmount LowLimit { get; set; }

        IssuedCurrencyAmount HighLimit { get; set; }

        string PreviousTxnID { get; set; }

        double PreviousTxnLgrSeq { get; set; }

        string LowNode { get; set; }

        string HighNode { get; set; }

        double? LowQualityIn { get; set; }

        double? LowQualityOut { get; set; }

        double? HighQualityIn { get; set; }

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
