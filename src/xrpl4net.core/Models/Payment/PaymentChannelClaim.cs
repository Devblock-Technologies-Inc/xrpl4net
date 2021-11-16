namespace Xrpl4net.Core
{

    /// <summary>
    /// Claim XRP from a payment channel, adjust the payment channel's expiration,
    /// or both.
    /// </summary>
    class PaymentChannelClaim : BaseTransaction
    {
        /// <summary>
        /// The amount of XRP, in drops, authorized by the Signature. This must match
        /// the amount in the signed message. This is the cumulative amount of XRP that
        /// can be dispensed by the channel, including XRP previously redeemed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Amount { get; set; }

        /// <summary>
        /// Total amount of XRP, in drops, delivered by this channel after processing
        /// this claim. Required to deliver XRP. Must be more than the total amount
        /// delivered by the channel so far, but not greater than the Amount of the
        /// signed claim. Must be provided except when closing the channel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Balance", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Balance { get; set; }

        /// <summary>
        /// The unique ID of the channel as a 64-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Channel", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Channel { get; set; }

        /// <summary>
        /// The public key used for the signature, as hexadecimal. This must match the
        /// PublicKey stored in the ledger for the channel. Required unless the sender
        /// of the transaction is the source address of the channel and the Signature
        /// field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublicKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? PublicKey { get; set; }

        /// <summary>
        /// The signature of this claim, as hexadecimal. The signed message contains
        /// the channel ID and the amount of the claim. Required unless the sender of
        /// the transaction is the source address of the channel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Signature", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Signature { get; set; }

    }
}

