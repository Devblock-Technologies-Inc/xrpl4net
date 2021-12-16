using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.ServerInfo
{
    public class ServerInfoResponse : BaseResponse
    {
        public ServerInfoResult result { get; set; }
    }

    public class ServerInfoResult
    {

    }
}
