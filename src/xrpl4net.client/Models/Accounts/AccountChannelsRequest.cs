using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountChannelsRequest : BaseRequest
    {
        public override string method => "account_channels";

        [JsonProperty("params")]
        public AccountChannelsRequestParams[] Params { get; set; }
    }

    public class AccountChannelsRequestParams
    {
        public string account { get; set; }

        public string destination_account { get; set; }

        public string ledger_index { get; set; }
    }
}
