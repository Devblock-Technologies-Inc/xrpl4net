using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerCurrentResponse : BaseResponse
    {
        public LedgerCurrentResult result { get; set; }

    }

    public class LedgerCurrentResult
    {
        public uint ledger_current_index { get; set; }

        public string status { get; set; }
    }
}
