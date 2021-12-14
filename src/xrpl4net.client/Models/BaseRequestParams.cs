using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models
{
    public class BaseRequestParams
    {
        public string ledger_hash { get; set; }

        public string ledger_index { get; set; }

        public int limit { get; set; }
    }
}
