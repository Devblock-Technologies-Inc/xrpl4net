namespace Xrpl4net.Core
{
    class Ticket : BaseLedgerEntry
    {
        string LedgerEntryType => "Ticket";

        string Account { get; set; }

        double Flags { get; set; }

        string OwnerNode { get; set; }

        double PreviousTxnID { get; set; }

        double TicketSequence { get; set; }

    }
}
