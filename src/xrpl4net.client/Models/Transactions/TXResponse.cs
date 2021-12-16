using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TXResponse : BaseResponse
    {
        public TXResult result { get; set; }
    }

    public class TXResult
    {
        public string Account { get; set; }

        public string Fee { get; set; }

        public int Flags { get; set; }

        public int LastLedgerSequence { get; set; }

        public int OfferSequence { get; set; }

        public int Sequence { get; set; }
    }
}
