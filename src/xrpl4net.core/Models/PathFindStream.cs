namespace Xrpl4net.Core
{

    /// <summary>
    /// The path_find method searches for a path along which a transaction can
    /// possibly be made, and periodically sends updates when the path changes over
    /// time.
    /// </summary>
    class PathFindStream : BaseStream
    {
        /// <summary>
        /// Array of objects with suggested paths to take. If empty, then no paths
        /// were found connecting the source and destination accounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternatives", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralSystemArrayPathsComputedAmountSourceAmount Alternatives { get; set; }

        /// <summary>
        /// Unique address of the account that would receive a transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string DestinationAccount { get; set; }

        /// <summary>
        /// Currency Amount that the destination would receive in a transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount DestinationAmount { get; set; }

        /// <summary>
        /// If false, this is the result of an incomplete search. A later reply may
        /// have a better path. If true, then this is the best path found. (It is still
        /// theoretically possible that a better path could exist, but rippled won't
        /// find it.) Until you close the pathfinding request, rippled continues to
        /// send updates each time a new ledger closes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_reply", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool FullReply { get; set; }

        /// <summary>
        /// The ID provided in the WebSocket request is included again at this level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.StringDoubleUnion Id { get; set; }

        /// <summary>
        /// Currency Amount that would be spent in the transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_max", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? SendMax { get; set; }

        /// <summary>
        /// Unique address that would send a transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string SourceAccount { get; set; }

    }
}

