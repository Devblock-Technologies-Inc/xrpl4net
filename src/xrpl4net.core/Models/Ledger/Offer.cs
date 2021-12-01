namespace Xrpl4net.Core
{
    class Offer : BaseLedgerEntry
    {
        string LedgerEntryType => "Offer";

        double Flags { get; set; }

        string Account { get; set; }

        double Sequence { get; set; }

        Amount TakerPays { get; set; }

        Amount TakerGets { get; set; }

        string BookDirectory { get; set; }

        string BookNode { get; set; }

        string OwnerNode { get; set; }

        string PreviousTxnID { get; set; }

        double PreviousTxnLgrSeq { get; set; }

        double? Expiration { get; set; }
    }

    enum OfferFlags
    {
        LsfPassive = 0x00010000,
        LsfSell = 0x00020000,
    }
}
