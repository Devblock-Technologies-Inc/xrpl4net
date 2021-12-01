namespace Xrpl4net.Core
{
    class DirectoryNode : BaseLedgerEntry
    {
        string LedgerEntryType => "DirectoryNode";

        double Flags { get; set; }

        string RootIndex { get; set; }

        string[] Indexes { get; set; }

        double IndexNext { get; set; }

        double IndexPrevious { get; set; }

        string Owner { get; set; }

        string TakerPaysCurrency { get; set; }

        string TakerPaysIssuer { get; set; }

        string TakerGetsCurrency { get; set; }

        string TakerGetsIssuer { get; set; }
    }
}
