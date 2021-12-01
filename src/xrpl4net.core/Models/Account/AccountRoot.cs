using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class AccountRoot
    {
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }


        string Balance { get; set; }

        double Flags { get; set; }

        double OwnerCount { get; set; }

        string PreviousTxnID { get; set; }

        double PreviousTxnLgrSeq { get; set; }

        double Sequence { get; set; }

        string AccountTxnID { get; set; }

        string Domain { get; set; }

        string EmailHash { get; set; }

        string MessageKey { get; set; }

        string RegularKey { get; set; }

        double? TicketCount { get; set; }

        double? TickSize { get; set; }

        double? TransferRate { get; set; }
    }
}
