namespace Xrpl4net.Core
{

    /// <summary>
    /// An AccountSet transaction modifies the properties of an account in the XRP
    /// Ledger.
    /// </summary>
    class AccountSet : BaseTransaction
    {
        /// <summary>
        /// Unique identifier of a flag to disable for this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ClearFlag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? ClearFlag { get; set; }

        /// <summary>
        /// The domain that owns this account, as a string of hex representing the.
        /// ASCII for the domain in lowercase.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Domain", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Domain { get; set; }

        /// <summary>
        /// Hash of an email address to be used for generating an avatar image.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EmailHash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? EmailHash { get; set; }

        /// <summary>
        /// Public key for sending encrypted messages to this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MessageKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? MessageKey { get; set; }

        /// <summary>
        /// Integer flag to enable for this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SetFlag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        AccountSetAsfFlags? SetFlag { get; set; }

        /// <summary>
        /// Tick size to use for offers involving a currency issued by this address.
        /// The exchange rates of those offers is rounded to this many significant
        /// digits. Valid values are 3 to 15 inclusive, or 0 to disable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TickSize", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? TickSize { get; set; }

        /// <summary>
        /// The fee to charge when users transfer this account's issued currencies,
        /// represented as billionths of a unit. Cannot be more than 2000000000 or less
        /// than 1000000000, except for the special case 0 meaning no fee.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TransferRate", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? TransferRate { get; set; }

    }

    enum AccountSetAsfFlags
    {
        /** The same as SetFlag: asfRequireDest. */
        TfRequireDestTag = 0x00010000,
        /** The same as ClearFlag: asfRequireDest. */
        TfOptionalDestTag = 0x00020000,
        /** The same as SetFlag: asfRequireAuth. */
        TfRequireAuth = 0x00040000,
        /** The same as ClearFlag: asfRequireAuth. */
        TfOptionalAuth = 0x00080000,
        /** The same as SetFlag: asfDisallowXRP. */
        TfDisallowXRP = 0x00100000,
        /** The same as ClearFlag: asfDisallowXRP. */
        TfAllowXRP = 0x00200000,
    }
}

