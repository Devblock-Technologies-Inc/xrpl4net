namespace Xrpl4net.Core
{

    /// <summary>
    /// The shape of an error response from rippled. xrpl.js handles rejections by
    /// throwing, and allowing the user to handle in the catch block of a promise.
    /// </summary>
    class ErrorResponse
    {
        [Newtonsoft.Json.JsonProperty("api_version", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double? ApiVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("error", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Error { get; set; }

        [Newtonsoft.Json.JsonProperty("error_code", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty("error_message", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? ErrorMessage { get; set; }

        [Newtonsoft.Json.JsonProperty("id", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TypedocConverter.GeneratedTypes.StringDoubleUnion Id { get; set; }

        [Newtonsoft.Json.JsonProperty("request", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Request Request { get; set; }

        [Newtonsoft.Json.JsonProperty("status", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("type", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Type { get; set; }

    }
}

