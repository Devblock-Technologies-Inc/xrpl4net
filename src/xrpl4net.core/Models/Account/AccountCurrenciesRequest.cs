namespace Xrpl4net.Core
{

    /// <summary>
    /// The `account_currencies` command retrieves a list of currencies that an
    /// account can send or receive, based on its trust lines. Expects an
    /// {@link AccountCurrenciesResponse}.
    /// </summary>
    class AccountCurrenciesRequest : BaseRequest
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
        /// If true, then the account field only accepts a public key or XRP Ledger
        /// address. Otherwise, account can be a secret or passphrase (not
        /// recommended). The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strict", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Strict { get; set; }

    }
}

