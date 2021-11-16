namespace Xrpl4net.Core
{

    /// <summary>
    /// The unsubscribe command tells the server to stop sending messages for a
    /// particular subscription or set of subscriptions. Expects a response in the
    /// form of an {@link UnsubscribeResponse}.
    /// </summary>
    class UnsubscribeRequest : BaseRequest
    {
        /// <summary>
        /// Array of unique account addresses to stop receiving updates for, in the.
        /// XRP Ledger's base58 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accounts", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string[]? Accounts { get; set; }

        /// <summary>
        /// Like accounts, but for accounts_proposed subscriptions that included
        /// not-yet-validated transactions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accounts_proposed", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string[]? AccountsProposed { get; set; }

        /// <summary>
        /// Array of objects defining order books to unsubscribe from, as explained
        /// below.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("books", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Book[]? Books { get; set; }

        /// <summary>
        /// Array of string names of generic streams to unsubscribe from, including.
        /// Ledger, server, transactions, and transactions_proposed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streams", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        StreamType[]? Streams { get; set; }

    }
}

