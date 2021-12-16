using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerDataResquest : BaseRequest
    {
        public override string method => "ledger_data";

        [JsonProperty("params")]
        public LedgerDataResquestParams[] Params { get; set; }
    }

    public class LedgerDataResquestParams : BaseRequestParams
    {
        public bool binary { get; set; }
    }
}
