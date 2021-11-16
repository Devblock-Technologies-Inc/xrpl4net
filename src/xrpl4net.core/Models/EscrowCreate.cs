namespace Xrpl4net.Core
{

    /// <summary>
    /// Sequester XRP until the escrow process either finishes or is canceled.
    /// </summary>
    class EscrowCreate : BaseTransaction
    {
        /// <summary>
        /// Amount of XRP, in drops, to deduct from the sender's balance and escrow.
        /// Once escrowed, the XRP can either go to the Destination address (after the.
        /// FinishAfter time) or returned to the sender (after the CancelAfter time).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Amount { get; set; }

        /// <summary>
        /// The time, in seconds since the Ripple Epoch, when this escrow expires.
        /// This value is immutable; the funds can only be returned the sender after.
        /// this time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CancelAfter", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? CancelAfter { get; set; }

        /// <summary>
        /// Hex value representing a PREIMAGE-SHA-256 crypto-condition . The funds can.
        /// only be delivered to the recipient if this condition is fulfilled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Condition", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Condition { get; set; }

        /// <summary>
        /// Address to receive escrowed XRP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Destination", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Destination { get; set; }

        /// <summary>
        /// Arbitrary tag to further specify the destination for this escrowed.
        /// payment, such as a hosted recipient at the destination address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DestinationTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? DestinationTag { get; set; }

        /// <summary>
        /// The time, in seconds since the Ripple Epoch, when the escrowed XRP can be
        /// released to the recipient. This value is immutable; the funds cannot move.
        /// until this time is reached.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FinishAfter", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? FinishAfter { get; set; }

    }
}

