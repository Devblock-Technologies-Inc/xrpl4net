namespace Xrpl4net.Core
{

    /// <summary>
    /// Create or modify a trust line linking two accounts.
    /// </summary>
    class TrustSet : BaseTransaction
    {
        /// <summary>
        /// Object defining the trust line to create or modify, in the format of a
        /// Currency Amount.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LimitAmount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount LimitAmount { get; set; }

        /// <summary>
        /// Value incoming balances on this trust line at the ratio of this number per
        /// 1,000,000,000 units. A value of 0 is shorthand for treating balances at
        /// face value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("QualityIn", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? QualityIn { get; set; }

        /// <summary>
        /// Value outgoing balances on this trust line at the ratio of this number per
        /// 1,000,000,000 units. A value of 0 is shorthand for treating balances at
        /// face value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("QualityOut", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? QualityOut { get; set; }

    }
}

