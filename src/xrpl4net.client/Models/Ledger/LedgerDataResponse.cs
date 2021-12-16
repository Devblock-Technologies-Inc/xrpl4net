using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Ledger
{
    public class LedgerDataResponse : BaseResponse
    {
        public LedgerDataResult result { get; set; }
    }

    public class LedgerDataResult
    {
        public int ledger_index { get; set; }

        public string ledger_hash { get; set; }

        public LedgerDataState state { get; set; }
    }

    public class LedgerDataState
    {
        public string data { get; set; }

        public string index { get; set; }
    }
}
