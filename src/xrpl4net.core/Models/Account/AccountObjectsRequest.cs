namespace Xrpl4net.Core
{

    /// <summary>
    /// The account_objects command returns the raw ledger format for all objects
    /// owned by an account. For a higher-level view of an account's trust lines and
    /// balances, see the account_lines method instead. Expects a response in the
    /// form of an {@link AccountObjectsResponse}.
    /// </summary>
    class AccountObjectsRequest : BaseRequest
    {
        /// <summary>
        /// A unique identifier for the account, most commonly the account's address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Account { get; set; }

        /// <summary>
        /// If true, the response only includes objects that would block this account
        /// from being deleted. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deletion_blockers_only", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? DeletionBlockersOnly { get; set; }

        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or a shortcut string to choose a
        /// Ledger automatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// The maximum number of objects to include in the results. Must be within
        /// the inclusive range 10 to 400 on non-admin connections. The default is 200.
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
        /// If included, filter results to include only this type of ledger object.
        /// The valid types are: Check , DepositPreauth, Escrow, Offer, PayChannel,
        /// SignerList, Ticket, and RippleState (trust line).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        AccountObjectType? Type { get; set; }

    }
}

