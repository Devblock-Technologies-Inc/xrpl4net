using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.KeyGeneration
{
    public class WalletProposeResponse : BaseResponse
    {
        public WalletProposeResult result { get; set; }
    }

    public class WalletProposeResult
    {

    }
}
