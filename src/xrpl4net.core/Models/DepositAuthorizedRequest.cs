namespace Xrpl4net.Core
{

    /// <summary>
    /// The deposit_authorized command indicates whether one account is authorized to
    /// send payments directly to another. Expects a response in the form of a {@link
    /// DepositAuthorizedResponse}.
    /// </summary>
    class DepositAuthorizedRequest : BaseRequest
    {
        /// <summary>
        /// The recipient of a possible payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string DestinationAccount { get; set; }

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
        /// The sender of a possible payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string SourceAccount { get; set; }

    }
}

