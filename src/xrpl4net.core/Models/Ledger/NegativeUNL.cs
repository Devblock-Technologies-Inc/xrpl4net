
using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    public class DisabledValidator
    {
        [JsonProperty("firstLedgerSequence", NullValueHandling = NullValueHandling.Ignore)]
        double FirstLedgerSequence { get; set; }

        [JsonProperty("publicKey", NullValueHandling = NullValueHandling.Ignore)]
        string PublicKey { get; set; }
    }

    class NegativeUNL : BaseLedgerEntry
    {
        [JsonProperty("ledgerEntryType", NullValueHandling = NullValueHandling.Ignore)]
        string LedgerEntryType => "NegativeUNL";

        [JsonProperty("validatorToDisable", NullValueHandling = NullValueHandling.Ignore)]
        string ValidatorToDisable { get; set; }

        [JsonProperty("validatorToReEnable", NullValueHandling = NullValueHandling.Ignore)]
        string ValidatorToReEnable { get; set; }

        [JsonProperty("disabledValidator", NullValueHandling = NullValueHandling.Ignore)]
        DisabledValidator[] DisabledValidators { get; set; }
    }
}
