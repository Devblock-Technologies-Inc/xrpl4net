using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TXResponse : BaseResponse
    {
        public TXResult result { get; set; }
    }

    public class TXResult
    {
        public string Account { get; set; }

        public uint Amount { get; set; }

        public string Destination { get; set; }

        public string Fee { get; set; }

        public long Flags { get; set; }

        public long LastLedgerSequence { get; set; }

        public long OfferSequence { get; set; }

        public long Sequence { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public Meta meta { get; set; }
    }

    public class Meta
    {
        public string TransactionResult { get; set; }

        public uint TransactionIndex { get; set; }

        public uint delivered_amount { get; set; }

        public AffectedNode[] AffectedNodes { get; set; }
    }

    public class AffectedNode
    {
        public ModifiedNode ModifiedNode { get; set; }
    }

    public class ModifiedNode
    {
        public string LedgerEntryType { get; set; }

        public string LedgerIndex { get; set; }

        public string PreviousTxnID { get; set; }

        public uint PreviousTxnLgrSeq { get; set; }

        public FinalField FinalFields { get; set; }

        public PreviousField PreviousFields { get; set; }
    }

    public class FinalField
    {
        public string Account { get; set; }

        public float Balance { get; set; }

        public uint Flags { get; set; }

        public uint OwnerCount { get; set; }

        public uint Sequence { get; set; }
    }

    public class PreviousField
    {
        public float Balance { get; set; }

        public uint Sequence { get; set; }
    }
}
