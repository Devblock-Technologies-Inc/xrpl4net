namespace Xrpl4net.Core
{

    /// <summary>
    /// The gateway_balances command calculates the total balances issued by a given
    /// account, optionally excluding amounts held by operational addresses. Expects
    /// a response in the form of a {@link GatewayBalancesResponse}.
    /// </summary>
    class GatewayBalancesRequest : BaseRequest
    {
        /// <summary>
        /// The Address to check. This should be the issuing address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Account { get; set; }

        /// <summary>
        /// An operational address to exclude from the balances issued, or an array of
        /// Such addresses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotwallet", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.StringArrayStringUnion? Hotwallet { get; set; }

        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger version to use, or a shortcut string to
        /// choose a ledger automatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// If true, only accept an address or public key for the account parameter.
        /// Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strict", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Strict { get; set; }

    }
}

