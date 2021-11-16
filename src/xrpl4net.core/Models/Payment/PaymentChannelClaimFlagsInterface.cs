namespace Xrpl4net.Core
{

    /// <summary>
    /// Map of flags to boolean values representing {@link PaymentChannelClaim}
    /// transaction flags.
    /// </summary>
    class PaymentChannelClaimFlagsclass : GlobalFlags
    {
        /// <summary>
        /// Request to close the channel. Only the channel source and destination
        /// addresses can use this flag. This flag closes the channel immediately if it
        /// has no more XRP allocated to it after processing the current claim, or if
        /// the destination address uses it. If the source address uses this flag when
        /// the channel still holds XRP, this schedules the channel to close after
        /// SettleDelay seconds have passed. (Specifically, this sets the Expiration of
        /// the channel to the close time of the previous ledger plus the channel's
        /// SettleDelay time, unless the channel already has an earlier Expiration
        /// time.) If the destination address uses this flag when the channel still
        /// holds XRP, any XRP that remains after processing the claim is returned to
        /// the source address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfClose", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfClose { get; set; }

        /// <summary>
        /// Clear the channel's Expiration time. (Expiration is different from the
        /// channel's immutable CancelAfter time.) Only the source address of the
        /// payment channel can use this flag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfRenew", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfRenew { get; set; }

    }
}

