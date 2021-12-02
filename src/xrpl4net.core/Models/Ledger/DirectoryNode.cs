using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class DirectoryNode : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "DirectoryNode";

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        double Flags { get; set; }

        [JsonProperty("rootIndex", NullValueHandling = NullValueHandling.Ignore)]
        string RootIndex { get; set; }

        [JsonProperty("indexes", NullValueHandling = NullValueHandling.Ignore)]
        string[] Indexes { get; set; }

        [JsonProperty("indexNext", NullValueHandling = NullValueHandling.Ignore)]
        double IndexNext { get; set; }

        [JsonProperty("indexPrevious", NullValueHandling = NullValueHandling.Ignore)]
        double IndexPrevious { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        string Owner { get; set; }

        [JsonProperty("takerPaysCurrency", NullValueHandling = NullValueHandling.Ignore)]
        string TakerPaysCurrency { get; set; }

        [JsonProperty("takerPaysIssuer", NullValueHandling = NullValueHandling.Ignore)]
        string TakerPaysIssuer { get; set; }

        [JsonProperty("takerGetsCurrency", NullValueHandling = NullValueHandling.Ignore)]
        string TakerGetsCurrency { get; set; }

        [JsonProperty("takerGetsIssuer", NullValueHandling = NullValueHandling.Ignore)]
        string TakerGetsIssuer { get; set; }
    }
}
