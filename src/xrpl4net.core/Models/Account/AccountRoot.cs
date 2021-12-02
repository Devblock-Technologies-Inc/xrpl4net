using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class AccountRoot
    {
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        string Balance { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("ownerCount", NullValueHandling = NullValueHandling.Ignore)]
        double OwnerCount { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        double PreviousTxnLgrSeq { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        double Sequence { get; set; }

        [JsonProperty("accountTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string AccountTxnID { get; set; }

        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        string Domain { get; set; }

        [JsonProperty("emailHash", NullValueHandling = NullValueHandling.Ignore)]
        string EmailHash { get; set; }

        [JsonProperty("messageKey", NullValueHandling = NullValueHandling.Ignore)]
        string MessageKey { get; set; }

        [JsonProperty("regularKey", NullValueHandling = NullValueHandling.Ignore)]
        string RegularKey { get; set; }

        [JsonProperty("ticketCount", NullValueHandling = NullValueHandling.Ignore)]
        double? TicketCount { get; set; }

        [JsonProperty("tickSize", NullValueHandling = NullValueHandling.Ignore)]
        double? TickSize { get; set; }

        [JsonProperty("transferRate", NullValueHandling = NullValueHandling.Ignore)]
        double? TransferRate { get; set; }
    }
}
