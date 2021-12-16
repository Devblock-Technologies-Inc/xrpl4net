using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TransactionEntryResponse : BaseResponse
    {
        public TransactionEntryResult result { get; set; }
    }

    public class TransactionEntryResult
    {
        public int ledger_index { get; set; }

        public string ledger_hash { get; set; }

        public TransactionDefinition tx_json { get; set; }
    }
}
