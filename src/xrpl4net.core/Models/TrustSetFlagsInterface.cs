namespace Xrpl4net.Core
{

    /// <summary>
    /// Map of flags to boolean values representing {@link TrustSet} transaction
    /// flags.
    /// </summary>
    class TrustSetFlagsclass : GlobalFlags
    {
        /// <summary>
        /// Unfreeze the trust line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfClearFreeze", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfClearFreeze { get; set; }

        /// <summary>
        /// Disable the No Ripple flag, allowing rippling on this trust line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfClearNoRipple", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfClearNoRipple { get; set; }

        /// <summary>
        /// Freeze the trust line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfSetFreeze", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfSetFreeze { get; set; }

        /// <summary>
        /// Enable the No Ripple flag, which blocks rippling between two trust lines
        /// of the same currency if this flag is enabled on both.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfSetNoRipple", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfSetNoRipple { get; set; }

        /// <summary>
        /// Authorize the other party to hold currency issued by this account. (No
        /// effect unless using the asfRequireAuth AccountSet flag.) Cannot be unset.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfSetfAuth", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfSetfAuth { get; set; }

    }
}

