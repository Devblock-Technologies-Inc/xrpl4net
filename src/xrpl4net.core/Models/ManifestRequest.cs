namespace Xrpl4net.Core
{

    /// <summary>
    /// The `manifest` method reports the current "manifest" information for a given
    /// validator public key. The "manifest" is the public portion of that
    /// validator's configured token. Expects a response in the form of a {@link
    /// ManifestResponse}.
    /// </summary>
    class ManifestRequest : BaseRequest
    {
        /// <summary>
        /// The base58-encoded public key of the validator to look up. This can be the
        /// master public key or ephemeral public key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_key", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string PublicKey { get; set; }

    }
}

