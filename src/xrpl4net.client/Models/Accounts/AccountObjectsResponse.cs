using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountObjectsResponse : BaseResponse
    {
        public AccountObjectsResult result { get; set; }
    }

    public class AccountObjectsResult
    {
        public string account { get; set; }

        public AccountObjects account_objects { get; set; }

        public string ledger_hash { get; set; }

        public int ledger_index { get; set; }
    }

    public class AccountObjects
    {
        public string index { get; set; }

        public int Flags { get; set; }

        public string LedgerEntryType { get; set; }

        public string LowNode { get; set; }

        public string PreviousTxnID { get; set; }

        public int PreviousTxnLgrSeq { get; set; }
    }
}
