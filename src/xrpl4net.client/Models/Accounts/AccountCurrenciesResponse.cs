using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountCurrenciesResponse : BaseResponse
    {
        public string[] send_currencies { get; set; }

        public string[] receive_currencies { get; set; }
    }

}
