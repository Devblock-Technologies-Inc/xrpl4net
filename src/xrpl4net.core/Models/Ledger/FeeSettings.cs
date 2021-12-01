namespace Xrpl4net.Core
{
    class FeeSettings : BaseLedgerEntry
    {
        string LedgerEntryType => "FeeSettings";

        string BaseFee { get; set; }

        double ReferenceFeeUnits { get; set; }

        double ReserveBase { get; set; }

        double ReserveIncrement { get; set; }

        double Flags { get; set; }
    }
}
