namespace Xrpl4net.Core
{

    /// <summary>
    /// An AccountDelete transaction deletes an account and any objects it owns in
    /// the XRP Ledger, if possible, sending the account's remaining XRP to a
    /// specified destination account.
    /// </summary>
    class AccountDelete : BaseTransaction
    {
        /// <summary>
        /// The address of an account to receive any leftover XRP after deleting the
        /// sending account. Must be a funded account in the ledger, and must not be.
        /// the sending account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Destination", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Destination { get; set; }

        /// <summary>
        /// Arbitrary destination tag that identifies a hosted recipient or other.
        /// information for the recipient of the deleted account's leftover XRP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DestinationTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? DestinationTag { get; set; }

    }
}

