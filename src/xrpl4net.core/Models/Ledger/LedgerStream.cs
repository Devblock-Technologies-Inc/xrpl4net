namespace Xrpl4net.Core
{

    /// <summary>
    /// The `ledger` stream only sends `ledgerClosed` messages when the consensus
    /// process declares a new validated ledger. The message identifies the ledger
    /// And provides some information about its contents.
    /// </summary>
    class LedgerStream : BaseStream
    {
        /// <summary>
        /// The reference transaction cost as of this ledger version, in drops of XRP.
        /// If this ledger version includes a SetFee pseudo-transaction the new.
        /// Transaction cost applies starting with the following ledger version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_base", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double FeeBase { get; set; }

        /// <summary>
        /// The reference transaction cost in "fee units".
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_ref", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double FeeRef { get; set; }

        /// <summary>
        /// The identifying hash of the ledger version that was closed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger that was closed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double LedgerIndex { get; set; }

        /// <summary>
        /// The time this ledger was closed, in seconds since the Ripple Epoch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_time", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double LedgerTime { get; set; }

        /// <summary>
        /// The minimum reserve, in drops of XRP, that is required for an account. If
        /// this ledger version includes a SetFee pseudo-transaction the new base reserve
        /// applies starting with the following ledger version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_base", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double ReserveBase { get; set; }

        /// <summary>
        /// The owner reserve for each object an account owns in the ledger, in drops
        /// of XRP. If the ledger includes a SetFee pseudo-transaction the new owner
        /// reserve applies after this ledger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_inc", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double ReserveInc { get; set; }

        /// <summary>
        /// Number of new transactions included in this ledger version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("txn_count", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double TxnCount { get; set; }

        /// <summary>
        /// Range of ledgers that the server has available. This may be a disjoint
        /// sequence such as 24900901-24900984,24901116-24901158. This field is not
        /// returned if the server is not connected to the network, or if it is
        /// connected but has not yet obtained a ledger from the network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validated_ledgers", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? ValidatedLedgers { get; set; }

    }
}

