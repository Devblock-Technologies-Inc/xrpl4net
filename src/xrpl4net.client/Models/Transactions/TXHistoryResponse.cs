using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TXHistoryResponse : BaseResponse
    {
        public TXHistoryResult result { get; set; }
    }

    public class TXHistoryResult
    {
        public uint index { get; set; }

        public TransactionDefinition[] txs { get; set; }
    }
}
