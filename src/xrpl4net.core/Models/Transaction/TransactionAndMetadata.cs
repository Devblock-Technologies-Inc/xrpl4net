namespace Xrpl4net.Core
{

    /// <summary>
    
    /// </summary>
    class TransactionAndMetadata
    {
        [Newtonsoft.Json.JsonProperty("metadata", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        TransactionMetadata Metadata { get; set; }

        [Newtonsoft.Json.JsonProperty("transaction", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Transaction Transaction { get; set; }

    }
}

