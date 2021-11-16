namespace Xrpl4net.Core
{

    /// <summary>
    /// The submit method applies a transaction and sends it to the network to be
    /// confirmed and included in future ledgers. Expects a response in the form of a
    /// {@link SubmitResponse}.
    /// </summary>
    class SubmitRequest : BaseRequest
    {
        /// <summary>
        /// If true, and the transaction fails locally, do not retry or relay the
        /// transaction to other servers. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_hard", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? FailHard { get; set; }

        /// <summary>
        /// The complete transaction in hex string format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tx_blob", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string TxBlob { get; set; }

    }
}

