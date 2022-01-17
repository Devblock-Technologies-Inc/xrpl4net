using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Transactions
{
    public class TransactionDefinition
    {
        public string Account { get; set; }

        public string TransactionType { get; set; }

        public string Destination { get; set; }

        public string Amount { get; set; }

        public string Fee { get; set; }

        public long Flags { get; set; }

        public long Sequence { get; set; }

        public string SigningPubKey { get; set; }

        public string TxnSignature { get; set; }

        public string hash { get; set; }
    }

    public class Amount
    {
        public string currency { get; set; }

        public string issuer { get; set; }

        public int value { get; set; }
    }
}
