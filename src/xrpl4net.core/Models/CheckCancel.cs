namespace Xrpl4net.Core
{

    /// <summary>
    /// Cancels an unredeemed Check, removing it from the ledger without sending any
    /// money. The source or the destination of the check can cancel a Check at any
    /// time using this transaction type. If the Check has expired, any address can
    /// cancel it.
    /// </summary>
    class CheckCancel : BaseTransaction
    {
        /// <summary>
        /// The ID of the Check ledger object to cancel as a 64-character hexadecimal
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CheckID", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string CheckID { get; set; }

    }
}

