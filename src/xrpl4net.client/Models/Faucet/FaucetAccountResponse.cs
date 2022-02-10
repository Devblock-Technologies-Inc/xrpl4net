using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Faucet
{
    public class FaucetAccountResponse
    {
        public Account account { get; set; }

        public string secret { get; set; }
        public long amount { get; set; }
    }

    public class Account
    {
        public string xAddress { get; set; }

        public string classicAddress { get; set; }

        public string address { get; set; }
    }
}
