namespace Xrpl4net.Core
{

    /// <summary>
    /// An OfferCreate transaction is effectively a limit order . It defines an
    /// intent to exchange currencies, and creates an Offer object if not completely.
    /// Fulfilled when placed. Offers can be partially fulfilled.
    /// </summary>
    class OfferCreate : BaseTransaction
    {
        /// <summary>
        /// Time after which the offer is no longer active, in seconds since the.
        /// Ripple Epoch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Expiration", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Expiration { get; set; }

        /// <summary>
        /// An offer to delete first, specified in the same way as OfferCancel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferSequence", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? OfferSequence { get; set; }

        /// <summary>
        /// The amount and type of currency being provided by the offer creator.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TakerGets", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount TakerGets { get; set; }

        /// <summary>
        /// The amount and type of currency being requested by the offer creator.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TakerPays", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount TakerPays { get; set; }

    }
}

