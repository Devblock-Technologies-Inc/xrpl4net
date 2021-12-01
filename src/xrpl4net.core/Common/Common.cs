using Newtonsoft.Json;

namespace Xrpl4net.Core
{
    class IssuedCurrency
    {

        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("issuer")]
        public string Issuer;

    }

    class PathStep
    {

        [JsonProperty("account")]
        public string Account;

        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("issuer")]
        public string Issuer;

    }

    class IssuedCurrencyAmount : IssuedCurrency
    {
        [JsonProperty("value")]
        string Value { get; set; }
    }
}
