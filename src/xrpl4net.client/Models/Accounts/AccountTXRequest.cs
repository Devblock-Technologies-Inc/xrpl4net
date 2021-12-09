using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountTXRequest : BaseRequest
    {
        public override string method => "account_tx";

        [JsonProperty("params")]
        public AccountTXRequestParams[] Params { get; set; }
    }

    public class AccountTXRequestParams
    {
        public string account { get; set; }

        public string ledger_index { get; set; }

        public bool binary { get; set; }

        public bool forward { get; set; }
    }
}
