namespace Xrpl4net.Core
{

    /// <summary>
    /// The tx method retrieves information on a single transaction, by its
    /// identifying hash. Expects a response in the form of a {@link TxResponse}.
    /// </summary>
    class TxRequest : BaseRequest
    {
        /// <summary>
        /// If true, return transaction data and metadata as binary serialized to
        /// hexadecimal strings. If false, return transaction data and metadata as.
        /// JSON. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("binary", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Binary { get; set; }

        /// <summary>
        /// Use this with min_ledger to specify a range of up to 1000 ledger indexes,
        /// ending with this ledger (inclusive). If the server cannot find the
        /// transaction, it confirms whether it was able to search all the ledgers in
        /// the requested range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_ledger", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? MaxLedger { get; set; }

        /// <summary>
        /// Use this with max_ledger to specify a range of up to 1000 ledger indexes,
        /// starting with this ledger (inclusive). If the server cannot find the
        /// transaction, it confirms whether it was able to search all the ledgers in
        /// this range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("min_ledger", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? MinLedger { get; set; }

        [Newtonsoft.Json.JsonProperty("transaction", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Transaction { get; set; }

    }
}

