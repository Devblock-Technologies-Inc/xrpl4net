namespace Xrpl4net.Core
{

    /// <summary>
    /// The `ledger_entry` method returns a single ledger object from the XRP Ledger
    /// in its raw format. Expects a response in the form of a {@link
    /// LedgerEntryResponse}.
    /// </summary>
    class LedgerEntryRequest : BaseRequest
    {
        /// <summary>
        /// Retrieve an AccountRoot object by its address. This is roughly equivalent
        /// to the an {@link AccountInfoRequest}.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_root", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? AccountRoot { get; set; }

        /// <summary>
        /// If true, return the requested ledger object's contents as a hex string in
        /// the XRP Ledger's binary format. Otherwise, return data in JSON format. The
        /// default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("binary", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Binary { get; set; }

        /// <summary>
        /// The object ID of a Check object to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Check { get; set; }

        /// <summary>
        /// Specify a DepositPreauth object to retrieve. If a string, must be the
        /// object ID of the DepositPreauth object, as hexadecimal. If an object,
        /// requires owner and authorized sub-fields.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deposit_preauth", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralStringAuthorizedStringOwnerStringUnion? DepositPreauth { get; set; }

        /// <summary>
        /// The DirectoryNode to retrieve. If a string, must be the object ID of the
        /// directory, as hexadecimal. If an object, requires either `dir_root` o
        /// Owner as a sub-field, plus optionally a `sub_index` sub-field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("directory", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralStringDirRootStringOwnerDoubleSubIndexStringUnion? Directory { get; set; }

        /// <summary>
        /// The Escrow object to retrieve. If a string, must be the object ID of the
        /// escrow, as hexadecimal. If an object, requires owner and seq sub-fields.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("escrow", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralStringOwnerDoubleSeqStringUnion? Escrow { get; set; }

        [Newtonsoft.Json.JsonProperty("index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Index { get; set; }

        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or a shortcut string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// The Offer object to retrieve. If a string, interpret as the unique object
        /// ID to the Offer. If an object, requires the sub-fields `account` and `seq`
        /// to uniquely identify the offer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offer", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralStringAccountDoubleSeqStringUnion? Offer { get; set; }

        /// <summary>
        /// The object ID of a PayChannel object to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_channel", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? PaymentChannel { get; set; }

        /// <summary>
        /// Object specifying the RippleState (trust line) object to retrieve. The
        /// accounts and currency sub-fields are required to uniquely specify the
        /// rippleState entry to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ripple_state", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralSystemArrayAccountsStringCurrency? RippleState { get; set; }

        /// <summary>
        /// The Ticket object to retrieve. If a string, must be the object ID of the
        /// Ticket, as hexadecimal. If an object, the `owner` and `ticket_sequence`
        /// sub-fields are required to uniquely specify the Ticket entry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.LiteralStringOwnerDoubleTicketSequenceStringUnion? Ticket { get; set; }

    }
}

