namespace Xrpl4net.Core
{
    class Escrow : BaseLedgerEntry  
    {

        string LedgerEntryType => "Escrow";

        string Account { get; set; }

        string Destination { get; set; }

        string Amount { get; set; }

        string Condition { get; set; }

        double CancelAfter { get; set; }

        double FinishAfter { get; set; }

        double Flags { get; set; }

        double SourceTag { get; set; }

        double DestinationTag { get; set; }

        string OwnerNode { get; set; }

        string DestinationNode { get; set; }

        string PreviousTxnID { get; set; }

        double? PreviousTxnLgrSeq { get; set; }
    }
}
