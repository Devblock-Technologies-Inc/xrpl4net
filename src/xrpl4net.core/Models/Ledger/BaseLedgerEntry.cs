using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class BaseLedgerEntry
    {
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        string Index { get; set; }
    }
}
