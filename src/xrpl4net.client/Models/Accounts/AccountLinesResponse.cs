using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountLinesResponse : BaseResponse
    {
        public AccountLinesResult result { get; set; }
    }

    public class AccountLinesResult
    {
        public string account { get; set; }

        public string status { get; set; }
    }

    public class Lines
    {
        public string account { get; set; }

        public string currency { get; set; }

        public string limit { get; set; }

        public int quality_in { get; set; }

        public int quality_out { get; set; }

        public bool no_ripple { get; set; }

        public bool no_ripple_peer { get; set; }
    }
}
