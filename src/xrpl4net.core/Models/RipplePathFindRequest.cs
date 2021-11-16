namespace Xrpl4net.Core
{

    /// <summary>
    /// The `ripple_path_find` method is a simplified version of the path_find method
    /// that provides a single response with a payment path you can use right away.
    /// Expects a response in the form of a {@link RipplePathFindResponse}.
    /// </summary>
    class RipplePathFindRequest : BaseRequest
    {
        /// <summary>
        /// Unique address of the account that would receive funds in a transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string DestinationAccount { get; set; }

        /// <summary>
        /// Currency Amount that the destination account would receive in a
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount DestinationAmount { get; set; }

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
        /// Currency Amount that would be spent in the transaction. Cannot be used
        /// with `source_currencies`.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_max", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? SendMax { get; set; }

        /// <summary>
        /// Unique address of the account that would send funds in a transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string SourceAccount { get; set; }

        /// <summary>
        /// Array of currencies that the source account might want to spend. Each
        /// entry in the array should be a JSON object with a mandatory currency field
        /// and optional issuer field, like how currency amounts are specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_currencies", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        SourceCurrencyAmount? SourceCurrencies { get; set; }

    }
}

