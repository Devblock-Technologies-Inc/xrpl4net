namespace Xrpl4net.Core
{

    /// <summary>
    /// The `channel_verify` method checks the validity of a signature that can be
    /// used to redeem a specific amount of XRP from a payment channel. Expects a
    /// response in the form of a {@link ChannelVerifyResponse}.
    /// </summary>
    class ChannelVerifyRequest : BaseRequest
    {
        /// <summary>
        /// The amount of XRP, in drops, the provided signature authorizes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Amount { get; set; }

        /// <summary>
        /// The Channel ID of the channel that provides the XRP. This is a
        /// 64-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string ChannelId { get; set; }

        /// <summary>
        /// The public key of the channel and the key pair that was used to create the
        /// signature, in hexadecimal or the XRP Ledger's base58 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_key", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string PublicKey { get; set; }

        /// <summary>
        /// The signature to verify, in hexadecimal.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Signature { get; set; }

    }
}

