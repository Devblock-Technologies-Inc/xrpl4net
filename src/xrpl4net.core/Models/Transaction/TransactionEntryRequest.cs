namespace Xrpl4net.Core
{

    /// <summary>
    /// The `transaction_entry` method retrieves information on a single transaction
    /// from a specific ledger version. Expects a response in the form of a
    /// {@link TransactionEntryResponse}.
    /// </summary>
    class TransactionEntryRequest : BaseRequest
    {
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
        /// Unique hash of the transaction you are looking up.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tx_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string TxHash { get; set; }

    }
}

