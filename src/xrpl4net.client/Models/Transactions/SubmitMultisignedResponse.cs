using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class SubmitMultisignedResponse : BaseResponse
    {
        public SubmitMultisignedResult result { get; set; }
    }

    public class SubmitMultisignedResult
    {
        public string engine_result { get; set; }

        public int engine_result_code { get; set; }

        public string engine_result_message { get; set; }

        public string tx_blob { get; set; }

        public TransactionDefinition tx_json { get; set; }
    }
}
