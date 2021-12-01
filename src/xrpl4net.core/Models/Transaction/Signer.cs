using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
    class Signer
    {
        string Account { get; set; }

        string TxnSignature { get; set; }

        string SigningPubKey { get; set; }
    }
}
