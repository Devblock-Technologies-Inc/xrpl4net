namespace Xrpl4net.Core
{

    /// <summary>
    /// Map of flags to boolean values representing {@link Payment} transaction
    /// flags.
    /// </summary>
    class PaymentFlagsclass : GlobalFlags
    {
        /// <summary>
        /// Only take paths where all the conversions have an input:output ratio that
        /// is equal or better than the ratio of Amount:SendMax. See Limit Quality for
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfLimitQuality", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfLimitQuality { get; set; }

        /// <summary>
        /// Do not use the default path; only use paths included in the Paths field.
        /// This is intended to force the transaction to take arbitrage opportunities.
        /// Most clients do not need this.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfNoDirectRipple", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfNoDirectRipple { get; set; }

        /// <summary>
        /// If the specified Amount cannot be sent without spending more than SendMax,
        /// reduce the received amount instead of failing outright. See Partial.
        /// Payments for more details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfPartialPayment", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfPartialPayment { get; set; }

    }
}

