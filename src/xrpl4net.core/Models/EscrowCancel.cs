namespace Xrpl4net.Core
{

    /// <summary>
    /// Return escrowed XRP to the sender.
    /// </summary>
    class EscrowCancel : BaseTransaction
    {
        /// <summary>
        /// Transaction sequence (or Ticket  number) of EscrowCreate transaction that.
        /// created the escrow to cancel.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OfferSequence", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double OfferSequence { get; set; }

        /// <summary>
        /// Address of the source account that funded the escrow payment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Owner", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Owner { get; set; }

    }
}

