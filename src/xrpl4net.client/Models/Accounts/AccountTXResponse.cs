using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountTXResponse : BaseResponse
    {
        public AccountTXResult result { get; set; }
    }

    public class AccountTXResult
    {
        public string account { get; set; }

        public int ledger_index_min { get; set; }

        public int ledger_index_max { get; set; }

        public int limit { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public AccountTransactions[] transactions { get; set; }
    }

    public class AccountTransactions
    {

    }
}
