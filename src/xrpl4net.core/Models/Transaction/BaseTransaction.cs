namespace Xrpl4net.Core
{
    class BaseTransaction
    {

        string Account { get; set; }

        string TransactionType { get; set; }

        string Fee { get; set; }

        double? Sequence { get; set; }

        string AccountTxnID { get; set; }

        double? Flags { get; set; }

        double? LastLedgerSequence { get; set; }

        double? SourceTag { get; set; }

        string SigningPubKey { get; set; }

        double? TicketSequence { get; set; }

        string TxnSignature { get; set; }

        Memo[] Memos { get; set; }

        Signer[] Signers { get; set; }
    }
}
