namespace Xrpl4net.Core
{

    /// <summary>
    /// The subscribe method requests periodic notifications from the server when
    /// certain events happen. Expects a response in the form of a.
    /// {@link SubscribeResponse}.
    /// </summary>
    class SubscribeRequest : BaseRequest
    {
        /// <summary>
        /// Array with the unique addresses of accounts to monitor for validated
        /// transactions. The addresses must be in the XRP Ledger's base58 format.
        /// The server sends a notification for any transaction that affects at least
        /// one of these accounts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accounts", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string[]? Accounts { get; set; }

        /// <summary>
        /// Like accounts, but include transactions that are not yet finalized.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accounts_proposed", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string[]? AccountsProposed { get; set; }

        /// <summary>
        /// Array of objects defining order books  to monitor for updates, as detailed
        /// Below.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("books", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Book[]? Books { get; set; }

        /// <summary>
        /// Array of string names of generic streams to subscribe to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streams", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        StreamType[]? Streams { get; set; }

        /// <summary>
        /// URL where the server sends a JSON-RPC callbacks for each event.
        /// Admin-only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? Url { get; set; }

        /// <summary>
        /// Password to provide for basic authentication at the callback URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_password", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? UrlPassword { get; set; }

        /// <summary>
        /// Username to provide for basic authentication at the callback URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_username", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? UrlUsername { get; set; }

    }
}

