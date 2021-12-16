using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerEntryResponse : BaseResponse
    {
        public LedgerResult result { get; set; }
    }

    public class LedgerEntryResult 
    { 
        public string index { get; set; }

        public int ledger_index { get; set; }

        public string node_binary { get; set; }

        public LedgerEntryNode node { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }
    }

    public class LedgerEntryNode
    {
        public string Account { get; set; }

        public string AccountTxnID { get; set; }

        public string Balance { get; set; }

        public string Domain { get; set; }

        public string EmailHash { get; set; }

        public int Flags { get; set; }

        public string LedgerEntryType { get; set; }

        public string MessageKey { get; set; }

        public string OwnerCount { get; set; }

        public string PreviousTxnID { get; set; }

        public int PreviousTxnLgrSeq { get; set; }

        public string RegularKey { get; set; }

        public int Sequence { get; set; }

        public int TransferRate { get; set; }

        public string index { get; set; }
    }
}
