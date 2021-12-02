using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class SignerEntry
    {
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        string Account { get; set; }

        [JsonProperty("signerWeight", NullValueHandling = NullValueHandling.Ignore)]
        double SignerWeight { get; set; }
    }

    class SignerList : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "SignerList";

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("previousTxnID", NullValueHandling = NullValueHandling.Ignore)]
        string PreviousTxnID { get; set; }

        [JsonProperty("previousTxnLgrSeq", NullValueHandling = NullValueHandling.Ignore)]
        double PreviousTxnLgrSeq { get; set; }

        [JsonProperty("ownerNode", NullValueHandling = NullValueHandling.Ignore)]
        double OwnerNode { get; set; }

        [JsonProperty("signerEntries", NullValueHandling = NullValueHandling.Ignore)]
        SignerEntry[] SignerEntries { get; set; }

        [JsonProperty("signerListID", NullValueHandling = NullValueHandling.Ignore)]
        double SignerListID { get; set; }

        [JsonProperty("signerQuorum", NullValueHandling = NullValueHandling.Ignore)]
        double SignerQuorum { get; set; }

    }


    enum SignerListFlags
    {
        LsfOneOwnerCount = 0x00010000,
    }
}
