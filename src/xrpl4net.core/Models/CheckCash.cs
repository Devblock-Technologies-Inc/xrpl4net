namespace Xrpl4net.Core
{

    /// <summary>
    /// Attempts to redeem a Check object in the ledger to receive up to the amount
    /// authorized by the corresponding CheckCreate transaction. Only the Destination
    /// address of a Check can cash it with a CheckCash transaction.
    /// </summary>
    class CheckCash : BaseTransaction
    {
        /// <summary>
        /// Redeem the Check for exactly this amount, if possible. The currency must
        /// match that of the SendMax of the corresponding CheckCreate transaction. You.
        /// must provide either this field or DeliverMin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? Amount { get; set; }

        /// <summary>
        /// The ID of the Check ledger object to cash as a 64-character hexadecimal
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CheckID", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string CheckID { get; set; }

        /// <summary>
        /// Redeem the Check for at least this amount and for as much as possible. The
        /// currency must match that of the SendMax of the corresponding CheckCreate.
        /// transaction. You must provide either this field or Amount.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeliverMin", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? DeliverMin { get; set; }

    }
}

