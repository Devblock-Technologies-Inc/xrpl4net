namespace Xrpl4net.Core
{

    /// <summary>
    /// Map of flags to boolean values representing {@link OfferCreate} transaction
    /// flags.
    /// </summary>
    class OfferCreateFlagsclass : GlobalFlags
    {
        [Newtonsoft.Json.JsonProperty("tfFillOrKill", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfFillOrKill { get; set; }

        [Newtonsoft.Json.JsonProperty("tfImmediateOrCancel", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfImmediateOrCancel { get; set; }

        [Newtonsoft.Json.JsonProperty("tfPassive", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfPassive { get; set; }

        [Newtonsoft.Json.JsonProperty("tfSell", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfSell { get; set; }

    }
}

