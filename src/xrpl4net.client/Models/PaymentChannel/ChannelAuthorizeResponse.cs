using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.PaymentChannel
{
    public class ChannelAuthorizeResponse : BaseResponse
    {
        public ChannelAuthorizeResult result { get; set; }
    }

    public class ChannelAuthorizeResult
    {

    }
}
