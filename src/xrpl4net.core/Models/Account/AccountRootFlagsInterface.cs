using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class AccountRootFlagsInterface
    {
        [JsonProperty("lsfPasswordSpent", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfPasswordSpent { get; set; }

        [JsonProperty("lsfRequireDestTag", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfRequireDestTag { get; set; }

        [JsonProperty("lsfRequireAuth", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfRequireAuth { get; set; }

        [JsonProperty("lsfDisallowXRP", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfDisallowXRP { get; set; }

        [JsonProperty("lsfNoFreeze", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfNoFreeze { get; set; }

        [JsonProperty("lsfGlobalFreeze", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfGlobalFreeze { get; set; }

        [JsonProperty("lsfDefaultRipple", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfDefaultRipple { get; set; }

        [JsonProperty("lsfDepositAuth", NullValueHandling = NullValueHandling.Ignore)]
        bool? LsfDepositAuth { get; set; }
    }
}
