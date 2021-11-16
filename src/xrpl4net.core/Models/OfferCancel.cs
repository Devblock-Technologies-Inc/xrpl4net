namespace Xrpl4net.Core
{

    /// <summary>
    /// An OfferCancel transaction removes an Offer object from the XRP Ledger.
    /// </summary>
    class OfferCancel : BaseTransaction
    {
        /// <summary>
        /// The sequence number (or Ticket number) of a previous OfferCreate
        /// transaction. If specified, cancel any offer object in the ledger that was
        /// created by that transaction. It is not considered an error if the offer.
        /// specified does not exist.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferSequence", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double OfferSequence { get; set; }

    }
}

