namespace Xrpl4net.Core
{

    /// <summary>
    /// Deliver XRP from a held payment to the recipient.
    /// </summary>
    class EscrowFinish : BaseTransaction
    {
        /// <summary>
        /// Hex value matching the previously-supplied PREIMAGE-SHA-256.
        /// crypto-condition of the held payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Condition", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Condition { get; set; }

        /// <summary>
        /// Hex value of the PREIMAGE-SHA-256 crypto-condition fulfillment matching.
        /// the held payment's Condition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Fulfillment", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Fulfillment { get; set; }

        /// <summary>
        /// Transaction sequence of EscrowCreate transaction that created the held.
        /// payment to finish.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferSequence", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double OfferSequence { get; set; }

        /// <summary>
        /// Address of the source account that funded the held payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Owner", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Owner { get; set; }

    }
}

