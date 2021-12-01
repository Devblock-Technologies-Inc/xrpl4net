namespace Xrpl4net.Core
{
    interface Check : BaseLedgerEntry
    {
        string LedgerEntryType => "Check";

        string Account { get; set; }

        string Destination { get; set; }

        bool Flags { get; set; }

        string OwnerNode { get; set; }

        string PreviousTxnID { get; set; }  

        string PreviousTxnLgrSeq { get; set; }

        Amount SendMax { get; set; }

        double Sequence { get; set; }

        string DestinationNode { get; set; }

        double DestinationTag { get; set; }

        double Expiration { get; set; }

        string InvoiceID { get; set; }

        double SourceTag { get; set; }
    }
}
