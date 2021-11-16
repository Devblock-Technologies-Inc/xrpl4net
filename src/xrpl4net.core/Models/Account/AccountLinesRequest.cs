namespace Xrpl4net.Core
{

    /// <summary>
    /// The account_lines method returns information about an account's trust lines,
    ///  including balances in all non-XRP currencies and assets. All information
    /// retrieved is relative to a particular version of the ledger. Expects an
    /// {@link AccountLinesResponse}.
    /// </summary>
    class AccountLinesRequest : BaseRequest
    {
        /// <summary>
        /// A unique identifier for the account, most commonly the account's Address.
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
        /// Limit the number of trust lines to retrieve. The server is not required to
        /// honor this value. Must be within the inclusive range 10 to 400.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Limit { get; set; }

        /// <summary>
        /// Value from a previous paginated response. Resume retrieving data where
        /// that response left off.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        object? Marker { get; set; }

        /// <summary>
        /// The Address of a second account. If provided, show only lines of trust
        /// connecting the two accounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("peer", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Peer { get; set; }

    }
}

