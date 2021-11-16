namespace Xrpl4net.Core
{

    /// <summary>
    /// The validations stream sends messages whenever it receives validation
    /// messages, also called validation votes, regardless of whether or not the
    /// validation message is from a trusted validator.
    /// </summary>
    class ValidationStream : BaseStream
    {
        /// <summary>
        /// The value validationReceived indicates this is from the validations
        /// Stream.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amendments", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string[]? Amendments { get; set; }

        /// <summary>
        /// The amendments this server wants to be added to the protocol.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_fee", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? BaseFee { get; set; }

        /// <summary>
        /// The unscaled transaction cost (reference_fee value) this server wants to
        /// set by Fee voting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flags", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double Flags { get; set; }

        /// <summary>
        /// Bit-mask of flags added to this validation message. The flag 0x80000000
        /// indicates that the validation signature is fully-canonical. The flag
        /// 0x00000001 indicates that this is a full validation; otherwise it's a
        /// partial validation. Partial validations are not meant to vote for any
        /// particular ledger. A partial validation indicates that the validator is
        /// still online but not keeping up with consensus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool Full { get; set; }

        /// <summary>
        /// If true, this is a full validation. Otherwise, this is a partial
        /// validation. Partial validations are not meant to vote for any particular
        /// ledger. A partial validation indicates that the validator is still online
        /// but not keeping up with consensus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the proposed ledger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string LedgerIndex { get; set; }

        /// <summary>
        /// The local load-scaled transaction cost this validator is currently
        /// enforcing, in fee units.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("load_fee", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? LoadFee { get; set; }

        /// <summary>
        /// The validator's master public key, if the validator is using a validator
        /// token, in the XRP Ledger's base58 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("master_key", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? MasterKey { get; set; }

        /// <summary>
        /// The minimum reserve requirement (`account_reserve` value) this validator
        /// wants to set by fee voting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_base", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? ReserveBase { get; set; }

        /// <summary>
        /// The increment in the reserve requirement (owner_reserve value) this
        /// validator wants to set by fee voting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_inc", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? ReserveInc { get; set; }

        /// <summary>
        /// The signature that the validator used to sign its vote for this ledger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Signature { get; set; }

        /// <summary>
        /// When this validation vote was signed, in seconds since the Ripple Epoch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signing_time", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double SigningTime { get; set; }

        /// <summary>
        /// The public key from the key-pair that the validator used to sign the
        /// message, in the XRP Ledger's base58 format. This identifies the validator
        /// sending the message and can also be used to verify the signature. If the
        /// validator is using a token, this is an ephemeral public key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validation_public_key", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string ValidationPublicKey { get; set; }

    }
}

