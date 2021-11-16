namespace Xrpl4net.Core
{

    /// <summary>
    /// A Payment transaction represents a transfer of value from one account to
    /// another.
    /// </summary>
    class Payment : BaseTransaction
    {
        /// <summary>
        /// The amount of currency to deliver. For non-XRP amounts, the nested field
        /// names MUST be lower-case. If the tfPartialPayment flag is set, deliver up
        /// to this amount instead.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount Amount { get; set; }

        /// <summary>
        /// Minimum amount of destination currency this transaction should deliver.
        /// Only valid if this is a partial payment. For non-XRP amounts, the nested
        /// field names are lower-case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeliverMin", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? DeliverMin { get; set; }

        /// <summary>
        /// The unique address of the account receiving the payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Destination", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Destination { get; set; }

        /// <summary>
        /// Arbitrary tag that identifies the reason for the payment to the
        /// destination, or a hosted recipient to pay.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DestinationTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? DestinationTag { get; set; }

        /// <summary>
        /// Arbitrary 256-bit hash representing a specific reason or identifier for
        /// this payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("InvoiceID", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? InvoiceID { get; set; }

        /// <summary>
        /// Array of payment paths to be used for this transaction. Must be omitted
        /// for XRP-to-XRP transactions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Paths", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Path[]? Paths { get; set; }

        /// <summary>
        /// Highest amount of source currency this transaction is allowed to cost,
        /// including transfer fees, exchange rates, and slippage . Does not include
        /// the XRP destroyed as a cost for submitting the transaction. For non-XRP
        /// amounts, the nested field names MUST be lower-case. Must be supplied for
        /// cross-currency/cross-issue payments. Must be omitted for XRP-to-XRP
        /// Payments.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SendMax", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? SendMax { get; set; }

    }
}

