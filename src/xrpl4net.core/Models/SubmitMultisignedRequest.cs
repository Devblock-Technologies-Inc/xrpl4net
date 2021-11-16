namespace Xrpl4net.Core
{

    /// <summary>
    /// The `submit_multisigned` command applies a multi-signed transaction and sends
    /// it to the network to be included in future ledgers. Expects a response in the
    /// form of a {@link SubmitMultisignedRequest}.
    /// </summary>
    class SubmitMultisignedRequest : BaseRequest
    {
        /// <summary>
        /// If true, and the transaction fails locally, do not retry or relay the
        /// transaction to other servers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_hard", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? FailHard { get; set; }

        /// <summary>
        /// Transaction in JSON format with an array of Signers. To be successful, the
        /// weights of the signatures must be equal or higher than the quorum of the.
        /// {@link SignerList}.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tx_json", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Transaction TxJson { get; set; }

    }
}

