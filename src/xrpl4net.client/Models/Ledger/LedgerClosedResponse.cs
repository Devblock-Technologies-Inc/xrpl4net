using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerClosedResponse : BaseResponse
    {
        public LedgerClosedResult result { get; set; }
    }

    public class LedgerClosedResult
    {
        public string ledger_hash { get; set; }

        public int ledger_index { get; set; }

        public string status { get; set; }
    }
}
