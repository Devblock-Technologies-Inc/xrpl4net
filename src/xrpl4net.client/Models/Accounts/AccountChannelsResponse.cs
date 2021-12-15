using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountChannelsResponse : BaseResponse
    {
        public string account { get; set; }

        public Channels[] channels { get; set; }
    }

    public class Channels
    {
        public string account { get; set; }

        public string amount { get; set; }

        public string balance { get; set; }

        public string channel_id { get; set; }
    }
}
