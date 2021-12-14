using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.ServerInfo
{
    public class ServerInfoRequest : BaseRequest
    {
        public override string method => "server_info";
    }

}
