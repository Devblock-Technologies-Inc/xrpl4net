using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountLinesRequest : BaseRequest
    {
        public override string method => "account_currencies";

        [JsonProperty("params")]
        public AccountLinesRequestParams[] Params { get; set; }
    }

    public class AccountLinesRequestParams
    {
        public string account { get; set; }

        public string ledger_index { get; set; }
    }
}
