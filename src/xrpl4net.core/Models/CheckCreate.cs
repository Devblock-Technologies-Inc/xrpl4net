namespace Xrpl4net.Core
{

    /// <summary>
    /// Create a Check object in the ledger, which is a deferred payment that can be
    /// cashed by its intended destination. The sender of this transaction is the
    /// sender of the Check.
    /// </summary>
    class CheckCreate : BaseTransaction
    {
        /// <summary>
        /// The unique address of the account that can cash the Check.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Destination", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Destination { get; set; }

        /// <summary>
        /// Arbitrary tag that identifies the reason for the Check, or a hosted.
        /// recipient to pay.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DestinationTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? DestinationTag { get; set; }

        /// <summary>
        /// Time after which the Check is no longer valid, in seconds since the Ripple.
        /// Epoch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Expiration", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Expiration { get; set; }

        /// <summary>
        /// Arbitrary 256-bit hash representing a specific reason or identifier for.
        /// this Check.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("InvoiceID", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? InvoiceID { get; set; }

        /// <summary>
        /// Maximum amount of source currency the Check is allowed to debit the
        /// sender, including transfer fees on non-XRP currencies. The Check can only
        /// credit the destination with the same currency (from the same issuer, for
        /// non-XRP currencies). For non-XRP amounts, the nested field names MUST be.
        /// lower-case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SendMax", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount SendMax { get; set; }

    }
}

