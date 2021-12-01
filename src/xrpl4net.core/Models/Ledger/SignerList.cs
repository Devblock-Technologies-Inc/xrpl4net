namespace Xrpl4net.Core
{
    class SignerEntry
    {
        string Account { get; set; }

        double SignerWeight { get; set; }
    }

    class SignerList : BaseLedgerEntry
    {
        string LedgerEntryType => "SignerList";

        double Flags { get; set; }

        string PreviousTxnID { get; set; }

        double PreviousTxnLgrSeq { get; set; }

        double OwnerNode { get; set; }

        SignerEntry[] SignerEntries { get; set; }

        double SignerListID { get; set; }

        double SignerQuorum { get; set; }

    }


    enum SignerListFlags
    {
        LsfOneOwnerCount = 0x00010000,
    }
}
