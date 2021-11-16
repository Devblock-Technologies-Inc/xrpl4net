namespace Xrpl4net.Core
{

    /// <summary>
    /// Many subscriptions result in messages about transactions.
    /// </summary>
    class TransactionStream : BaseStream
    {
        /// <summary>
        /// String Transaction result code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_result", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string EngineResult { get; set; }

        /// <summary>
        /// Numeric transaction response code, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_result_code", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double EngineResultCode { get; set; }

        /// <summary>
        /// Human-readable explanation for the transaction response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine_result_message", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string EngineResultMessage { get; set; }

        /// <summary>
        /// The ledger index of the current in-progress ledger version for which this
        /// transaction is currently proposed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_current_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerCurrentIndex { get; set; }

        /// <summary>
        /// The identifying hash of the ledger version that includes this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger version that includes this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndex { get; set; }

        /// <summary>
        /// The transaction metadata, which shows the exact outcome of the transaction
        /// in detail.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TransactionMetadata? Meta { get; set; }

        [Newtonsoft.Json.JsonProperty("status", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Status { get; set; }

        /// <summary>
        /// The definition of the transaction in JSON format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Transaction Transaction { get; set; }

        /// <summary>
        /// If true, this transaction is included in a validated ledger and its
        /// outcome is final. Responses from the transaction stream should always be
        /// validated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validated", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Validated { get; set; }

        [Newtonsoft.Json.JsonProperty("warnings", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralDoubleIdStringMessage[]? Warnings { get; set; }

    }
}

