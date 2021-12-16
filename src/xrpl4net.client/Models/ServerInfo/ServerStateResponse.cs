using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.ServerInfo
{
    public class ServerStateResponse : BaseResponse
    {
        public ServerStateResult result { get; set; }
    }

    public class ServerStateResult
    {

    }
}
