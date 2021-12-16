using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class GatewayBalanceResponse : BaseResponse
    {
        public GatewayBalanceResult result { get; set; }
    }

    public class GatewayBalanceResult
    {
        public string account { get; set; }

        public string ledger_hash { get; set; }

        public int ledger_index { get; set; }

        public int ledger_current_index { get; set; }
    }
}
