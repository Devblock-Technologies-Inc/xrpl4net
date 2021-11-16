namespace Xrpl4net.Core
{

    /// <summary>
    /// Map of flags to boolean values representing {@link AccountSet} transaction
    /// flags.
    /// </summary>
    class AccountSetFlagsInterface
    {
        [Newtonsoft.Json.JsonProperty("tfAllowXRP", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfAllowXRP { get; set; }

        [Newtonsoft.Json.JsonProperty("tfDisallowXRP", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfDisallowXRP { get; set; }

        [Newtonsoft.Json.JsonProperty("tfOptionalAuth", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfOptionalAuth { get; set; }

        [Newtonsoft.Json.JsonProperty("tfOptionalDestTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfOptionalDestTag { get; set; }

        [Newtonsoft.Json.JsonProperty("tfRequireAuth", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfRequireAuth { get; set; }

        [Newtonsoft.Json.JsonProperty("tfRequireDestTag", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? TfRequireDestTag { get; set; }

    }
}

