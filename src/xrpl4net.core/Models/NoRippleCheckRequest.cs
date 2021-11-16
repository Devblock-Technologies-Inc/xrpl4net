namespace Xrpl4net.Core
{

    /// <summary>
    /// The `noripple_check` command provides a quick way to check the status of th
    /// default ripple field for an account and the No Ripple flag of its trust
    /// lines, compared with the recommended settings. Expects a response in the form
    /// of an {@link NoRippleCheckResponse}.
    /// </summary>
    class NoRippleCheckRequest : BaseRequest
    {
        /// <summary>
        /// A unique identifier for the account, most commonly the account's address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Account { get; set; }

        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or a shortcut string to choose a
        /// ledger automatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// The maximum number of trust line problems to include in the results.
        /// Defaults to 300.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Limit { get; set; }

        /// <summary>
        /// Whether the address refers to a gateway or user. Recommendations depend on
        /// the role of the account. Issuers must have Default Ripple enabled and must
        /// disable No Ripple on all trust lines. Users should have Default Ripple
        /// disabled, and should enable No Ripple on all trust lines.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Role { get; set; }

        /// <summary>
        /// If true, include an array of suggested transactions, as JSON objects,
        /// that you can sign and submit to fix the problems. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactions", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Transactions { get; set; }

    }
}

