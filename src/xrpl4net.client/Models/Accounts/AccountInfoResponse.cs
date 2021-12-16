using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.Accounts
{
    public class AccountInfoResponse : BaseResponse
    {
        public AccountInfoResult result { get; set; }
    }

    public class AccountInfoResult
    {
        public int ledger_current_index { get; set; }

        public AccountData account_data { get; set; }
    }

    public class AccountData : AccountRoot
    {
       
    }

    public abstract class AccountRoot
    {
        public string index { get; set; }

        public string LedgerEntryType { get; set; }

        public string Account { get; set; }

        public string Balance { get; set; }

        public string Domain { get; set; }

        public string EmailHash { get; set; }

        public uint Flags { get; set; }

        public string RegularKey { get; set; }
    }
}
