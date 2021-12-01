namespace Xrpl4net.Core
{
    class Majority
    {
        string Amendment { get; set; }

        double CloseTime { get; set; }
    }

    class Amendment : BaseLedgerEntry
    {
        string LedgerEntryType => "Amendments";

        string[] Amendments { get; set; }

        Majority[] Majorities { get; set; }

        bool Flags { get; set; }
    }
}
