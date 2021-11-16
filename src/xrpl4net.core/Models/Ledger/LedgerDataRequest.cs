namespace Xrpl4net.Core
{

    /// <summary>
    /// The `ledger_data` method retrieves contents of the specified ledger. You can
    /// iterate through several calls to retrieve the entire contents of a single
    /// ledger version.
    /// </summary>
    class LedgerDataRequest : BaseRequest
    {
        /// <summary>
        /// If set to true, return ledger objects as hashed hex strings instead of
        /// JSON.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("binary", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Binary { get; set; }

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
        /// Limit the number of ledger objects to retrieve. The server is not required
        /// to honor this value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Limit { get; set; }

        /// <summary>
        /// Value from a previous paginated response. Resume retrieving data where
        /// that response left off.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        object? Marker { get; set; }

    }
}

