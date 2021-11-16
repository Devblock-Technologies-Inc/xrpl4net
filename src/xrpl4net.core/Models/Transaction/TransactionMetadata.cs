namespace Xrpl4net.Core
{

    class TransactionMetadata
    {
        [Newtonsoft.Json.JsonProperty("AffectedNodes", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Node[] AffectedNodes { get; set; }

        [Newtonsoft.Json.JsonProperty("DeliveredAmount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? DeliveredAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("TransactionIndex", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double TransactionIndex { get; set; }

        [Newtonsoft.Json.JsonProperty("TransactionResult", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string TransactionResult { get; set; }

        [Newtonsoft.Json.JsonProperty("delivered_amount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        Amount? DeliveredAmount { get; set; }

    }
}

