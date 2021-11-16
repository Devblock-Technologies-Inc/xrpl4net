namespace Xrpl4net.Core
{

    /// <summary>
    /// The SignerListSet transaction creates, replaces, or removes a list of
    /// signers that can be used to multi-sign a transaction.
    /// </summary>
    class SignerListSet : BaseTransaction
    {
        /// <summary>
        /// Array of SignerEntry objects, indicating the addresses and weights of
        /// signers in this list. This signer list must have at least 1 member and no
        /// more than 8 members. No address may appear more than once in the list, nor
        /// may the Account submitting the transaction appear in the list.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SignerEntries", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        SignerEntry[] SignerEntries { get; set; }

        /// <summary>
        /// A target number for the signer weights. A multi-signature from this list
        /// is valid only if the sum weights of the signatures provided is greater than
        /// or equal to this value. To delete a signer list, use the value 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SignerQuorum", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double SignerQuorum { get; set; }

    }
}

