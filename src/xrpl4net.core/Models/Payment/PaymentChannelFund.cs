namespace Xrpl4net.Core
{

    /// <summary>
    /// Add additional XRP to an open payment channel, and optionally update the
    /// expiration time of the channel. Only the source address of the channel can
    /// use this transaction.
    /// </summary>
    class PaymentChannelFund : BaseTransaction
    {
        /// <summary>
        /// Amount of XRP in drops to add to the channel. Must be a positive amount
        /// of XRP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Amount { get; set; }

        /// <summary>
        /// The unique ID of the channel to fund as a 64-character hexadecimal
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Channel", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Channel { get; set; }

        /// <summary>
        /// New Expiration time to set for the channel in seconds since the Ripple
        /// Epoch. This must be later than either the current time plus the SettleDelay
        /// of the channel, or the existing Expiration of the channel. After the
        /// Expiration time, any transaction that would access the channel closes the
        /// channel without taking its normal action. Any unspent XRP is returned to
        /// the source address when the channel closes. (Expiration is separate from
        /// the channel's immutable CancelAfter time.) For more information, see the
        /// PayChannel ledger object type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Expiration", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Expiration { get; set; }

    }
}

