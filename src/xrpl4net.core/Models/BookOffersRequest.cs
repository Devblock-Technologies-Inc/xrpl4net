namespace Xrpl4net.Core
{

    /// <summary>
    /// The book_offers method retrieves a list of offers, also known as the order.
    /// Book, between two currencies. Returns an {@link BookOffersResponse}.
    /// </summary>
    class BookOffersRequest : BaseRequest
    {
        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or a shortcut string to choose a
        /// ledger automatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// If provided, the server does not provide more than this many offers in the
        /// results. The total number of results returned may be fewer than the limit,
        /// because the server omits unfunded offers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? Limit { get; set; }

        /// <summary>
        /// The Address of an account to use as a perspective. Unfunded offers placed
        /// by this account are always included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Taker { get; set; }

        /// <summary>
        /// Specification of which currency the account taking the offer would
        /// receive, as an object with currency and issuer fields (omit issuer for
        /// XRP), like currency amounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taker_gets", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TakerAmount TakerGets { get; set; }

        /// <summary>
        /// Specification of which currency the account taking the offer would pay, as
        /// an object with currency and issuer fields (omit issuer for XRP), like
        /// currency amounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taker_pays", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TakerAmount TakerPays { get; set; }

    }
}

