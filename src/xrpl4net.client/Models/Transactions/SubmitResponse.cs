using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class SubmitResponse : BaseResponse
    {
        public SubmitResult result { get; set; }
    }

    public class SubmitResult
    {
        public string engine_result { get; set; }

        public int engine_result_code { get; set; }

        public string engine_result_message { get; set; }

        public string tx_blob { get; set; }

        public int account_sequence_available { get; set; }

        public int account_sequence_next { get; set; }

        public bool applied { get; set; }

        public bool broadcast { get; set; }

        public bool kept { get; set; }

        public bool queued { get; set; }

        public string open_ledger_cost { get; set; }

        public int validated_ledger_index { get; set; }

        public TransactionDefinition tx_json { get; set; }
    }


}
