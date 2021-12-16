using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerResponse : BaseResponse
    {
        public LedgerResult result { get; set; }
    }

    public class LedgerResult
    {
        public string ledger_hash { get; set; }

        public int ledger_index { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public Ledger ledger { get; set; }
    }

    public class Ledger
    {
        public bool accepted { get; set; }

        public string account_hash { get; set; }

        public int close_flags { get; set; }

        public int close_time { get; set; }

        public string close_time_human { get; set; }

        public int close_time_resolution { get; set; }

        public bool closed { get; set; }

        public string hash { get; set; }

        public string ledger_hash { get; set; }

        public string ledger_index { get; set; }

        public int parent_close_time { get; set; }

        public string parent_hash { get; set; }

        public int seqNum { get; set; }

        public string totalCoins { get; set; }

        public string total_coins { get; set; }

        public string transaction_hash { get; set; }
    }
}
