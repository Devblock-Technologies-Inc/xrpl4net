using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.PaymentChannel
{
    public class ChannelVerifyResponse : BaseResponse
    {
        public ChannelVerifyResult result { get; set; }
    }

    public class ChannelVerifyResult
    {

    }
}
