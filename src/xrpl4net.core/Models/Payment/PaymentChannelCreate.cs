namespace Xrpl4net.Core
{

    /// <summary>
    /// Create a unidirectional channel and fund it with XRP. The address sending
    /// this transaction becomes the "source address" of the payment channel.
    /// </summary>
    class PaymentChannelCreate : BaseTransaction
    {
        /// <summary>
        /// Amount of XRP, in drops, to deduct from the sender's balance and set aside
        /// in this channel. While the channel is open, the XRP can only go to the
        /// Destination address. When the channel closes, any unclaimed XRP is returned
        /// to the source address's balance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Amount { get; set; }

        /// <summary>
        /// The time, in seconds since the Ripple Epoch, when this channel expires.
        /// Any transaction that would modify the channel after this time closes the
        /// channel without otherwise affecting it. This value is immutable; the
        /// channel can be closed earlier than this time but cannot remain open after
        /// this time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CancelAfter", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? CancelAfter { get; set; }

        /// <summary>
        /// Address to receive XRP claims against this channel. This is also known as
        /// the "destination address" for the channel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Destination", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Destination { get; set; }

        /// <summary>
        /// Arbitrary tag to further specify the destination for this payment channel,
        /// such as a hosted recipient at the destination address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DestinationTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? DestinationTag { get; set; }

        /// <summary>
        /// The public key of the key pair the source will use to sign claims against
        /// this channel in hexadecimal. This can be any secp256k1 or ed25519 public
        /// key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublicKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string PublicKey { get; set; }

        /// <summary>
        /// Amount of time the source address must wait before closing the channel if
        /// it has unclaimed XRP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SettleDelay", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double SettleDelay { get; set; }

    }
}

