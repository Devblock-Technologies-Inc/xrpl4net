namespace Xrpl4net.Core
{

    /// <summary>
    /// When you subscribe to one or more order books with the `books` field, you
    /// get back any transactions that affect those order books. Has the same format
    /// as a {@link TransactionStream} but the transaction can have a `owner_funds`
    /// field.
    /// </summary>
    class OrderBookStream : BaseStream
    {
        [Newtonsoft.Json.JsonProperty("engine_result", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string EngineResult { get; set; }

        [Newtonsoft.Json.JsonProperty("engine_result_code", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double EngineResultCode { get; set; }

        [Newtonsoft.Json.JsonProperty("engine_result_message", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string EngineResultMessage { get; set; }

        [Newtonsoft.Json.JsonProperty("ledger_current_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerCurrentIndex { get; set; }

        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndex { get; set; }

        [Newtonsoft.Json.JsonProperty("meta", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TransactionMetadata Meta { get; set; }

        [Newtonsoft.Json.JsonProperty("status", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("transaction", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.TransactionModifiedOfferCreateTransactionUnion Transaction { get; set; }

        [Newtonsoft.Json.JsonProperty("validated", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool Validated { get; set; }

    }
}

