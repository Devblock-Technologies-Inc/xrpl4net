namespace Xrpl4net.Core
{
    class LedgerHashes : BaseLedgerEntry
    {
        string LedgerEntryType => "LedgerHashes";

        double? LastLedgerSequence { get; set; }

        string[] Hashes { get; set; }

        double Flags { get; set; }
    }
}
