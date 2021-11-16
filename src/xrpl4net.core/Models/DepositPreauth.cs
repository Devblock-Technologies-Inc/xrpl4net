namespace Xrpl4net.Core
{

    /// <summary>
    /// A DepositPreauth transaction gives another account pre-approval to deliver
    /// payments to the sender of this transaction. This is only useful if the sender
    /// of this transaction is using (or plans to use) Deposit Authorization.
    /// </summary>
    class DepositPreauth : BaseTransaction
    {
        /// <summary>
        /// The XRP Ledger address of the sender to preauthorize.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Authorize", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Authorize { get; set; }

        /// <summary>
        /// The XRP Ledger address of a sender whose preauthorization should be.
        /// revoked.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Unauthorize", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Unauthorize { get; set; }

    }
}

