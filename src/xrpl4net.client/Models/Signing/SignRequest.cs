using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models.Transactions;

namespace Xrpl4net.Client.Models.Signing
{
    public class SignRequest : BaseRequest
    {
        public override string method => "sign";

        [JsonProperty("params")]
        public SignRequestParams Params { get; set; }
    }

    public class SignRequestParams
    {
        public TransactionDefinition tx_json { get; set; }

        public string secret { get; set; }

        public string seed { get; set; }

        public int fee_mult_max { get; set; }

        public int fee_div_max { get; set; }
    }
}
