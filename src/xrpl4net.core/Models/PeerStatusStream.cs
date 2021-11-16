namespace Xrpl4net.Core
{

    /// <summary>
    /// The admin-only `peer_status` stream reports a large amount of information on
    /// the activities of other rippled servers to which this server is connected, in
    /// particular their status in the consensus process.
    /// </summary>
    class PeerStatusStream : BaseStream
    {
        /// <summary>
        /// The type of event that prompted this message. See Peer Status Events for
        /// possible values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Action { get; set; }

        /// <summary>
        /// The time this event occurred, in seconds since the Ripple Epoch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double Date { get; set; }

        /// <summary>
        /// The identifying Hash of a ledger version to which this message pertains.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The Ledger Index of a ledger version to which this message pertains.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndex { get; set; }

        /// <summary>
        /// The largest Ledger Index the peer has currently available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index_max", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndexMax { get; set; }

        /// <summary>
        /// The smallest Ledger Index the peer has currently available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index_min", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LedgerIndexMin { get; set; }

    }
}

