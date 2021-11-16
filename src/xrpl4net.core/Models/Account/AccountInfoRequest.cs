namespace Xrpl4net.Core
{

    /// <summary>
    /// The `account_info` command retrieves information about an account, its
    /// activity, and its XRP balance. All information retrieved is relative to a
    /// particular version of the ledger. Returns an {@link AccountInfoResponse}.
    /// </summary>
    class AccountInfoRequest : BaseRequest
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
        /// Whether to get info about this account's queued transactions. Can only be
        /// used when querying for the data from the current open ledger. Not available
        /// from servers in Reporting Mode.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queue", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Queue { get; set; }

        /// <summary>
        /// Request SignerList objects associated with this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signer_lists", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? SignerLists { get; set; }

        /// <summary>
        /// If true, then the account field only accepts a public key or XRP Ledger
        /// address. Otherwise, account can be a secret or passphrase (not
        /// recommended). The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strict", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Strict { get; set; }

    }
}

