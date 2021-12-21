using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.ServerInfo
{
    public class FeeResponse : BaseResponse
    {
        public FeeResult result { get; set; }
    }

    public class FeeResult
    {
        public string current_ledger_size { get; set; }

        public string current_ledger_type { get;}

        public Drops drops { get; set; }
    }

    public class Drops
    {
        public string base_fee { get; set; }

        public string median_fee { get; set; }

        public string minimum_fee { get; set; }

        public string open_ledger_fee { get; set; }
    }
}
