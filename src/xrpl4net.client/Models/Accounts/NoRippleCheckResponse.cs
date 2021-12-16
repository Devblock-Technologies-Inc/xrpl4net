using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class NoRippleCheckResponse : BaseResponse
    {
        public NoRippleCheckResult result { get; set; }
    }

    public class NoRippleCheckResult
    {
        public int ledger_current_index { get; set; }
        
        public string[] problems { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public NoRippleCheckTransactions transactions { get; set; } 
    }

    public class NoRippleCheckTransactions
    {
        public string Account { get; set; }

        public int Fee { get; set; }

        public int Sequence { get; set; }

        public int SetFlag { get; set; }

        public string TransactionType { get; set; }
    }
}
