using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountOffersResponse : BaseResponse
    {
        public AccountOffersResult result { get; set; } 
    }

    public class AccountOffersResult
    {
        public string account { get; set; }

        public string ledger_hash { get; set; }

        public int ledger_index { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public Offers[] offers { get; set; }  
    }

    public class Offers
    {
        public int flags { get; set; }

        public string quality { get; set; }

        public int seq { get; set; }

        public string taker_gets { get; set; }

        public TakerPays taker_pays { get; set; }
    }

    public class TakerPays
    {
        public string currency { get; set; }

        public string issuer { get; set; }

        public string value { get; set; }
    }
}
