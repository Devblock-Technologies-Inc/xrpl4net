using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountCurrenciesResponse : BaseResponse
    {
        public AccountInfoResult result { get; set; }
    }

    public class AccountCurrenciesResult
    {
        public int ledger_index { get; set; }

        public string[] send_currencies { get; set; }

        public string[] receive_currencies { get; set; }
    }
}
