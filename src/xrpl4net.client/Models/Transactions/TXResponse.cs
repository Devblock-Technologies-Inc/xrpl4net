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

        public long Flags { get; set; }

        public long LastLedgerSequence { get; set; }

        public long OfferSequence { get; set; }

        public long Sequence { get; set; }

        public string status { get; set; }

        public bool validated { get; set; }

        public Meta meta { get; set; }
    }

    public class Meta
    {
        public string TransactionResult { get; set; }

        public uint TransactionIndex { get; set; }
    }
}
