namespace Xrpl4net.Core
{

    /// <summary>
    /// The account_offers method retrieves a list of offers made by a given account
    /// that are outstanding as of a particular ledger version. Expects a response in
    /// the form of a {@link AccountOffersResponse}.
    /// </summary>
    class AccountOffersRequest : BaseRequest
    {
        /// <summary>
        /// A unique identifier for the account, most commonly the account's Address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Account { get; set; }

        /// <summary>
        /// A 20-byte hex string identifying the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or "current", "closed", or
        /// "validated" to select a ledger dynamically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// Limit the number of transactions to retrieve. The server is not required
        /// to honor this value. Must be within the inclusive range 10 to 400.
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
        /// If true, then the account field only accepts a public key or XRP Ledger
        /// address. Otherwise, account can be a secret or passphrase (not
        /// recommended). The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strict", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Strict { get; set; }

    }
}

