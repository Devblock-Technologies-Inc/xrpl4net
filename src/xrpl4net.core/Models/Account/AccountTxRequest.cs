namespace Xrpl4net.Core
{

    /// <summary>
    /// The account_tx method retrieves a list of transactions that involved the
    /// specified account. Expects a response in the form of a {@link
    /// AccountTxResponse}.
    /// </summary>
    class AccountTxRequest : BaseRequest
    {
        /// <summary>
        /// A unique identifier for the account, most commonly the account's address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Account { get; set; }

        /// <summary>
        /// If true, return transactions as hex strings instead of JSON. The default is
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("binary", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Binary { get; set; }

        /// <summary>
        /// If true, returns values indexed with the oldest ledger first. Otherwise,
        /// the results are indexed with the newest ledger first.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("forward", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Forward { get; set; }

        /// <summary>
        /// Use to look for transactions from a single ledger only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// Use to look for transactions from a single ledger only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// Use to specify the most recent ledger to include transactions from. A
        /// value of -1 instructs the server to use the most recent validated ledger
        /// version available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index_max", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndexMax { get; set; }

        /// <summary>
        /// Use to specify the earliest ledger to include transactions from. A value
        /// of -1 instructs the server to use the earliest validated ledger version
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index_min", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndexMin { get; set; }

        /// <summary>
        /// Default varies. Limit the number of transactions to retrieve. The server
        /// is not required to honor this value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Limit { get; set; }

        /// <summary>
        /// Value from a previous paginated response. Resume retrieving data where
        /// that response left off. This value is stable even if there is a change in
        /// the server's range of available ledgers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        object? Marker { get; set; }

    }
}

