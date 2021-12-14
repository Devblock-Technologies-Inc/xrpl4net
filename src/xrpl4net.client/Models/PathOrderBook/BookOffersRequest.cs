using Newtonsoft.Json;

namespace Xrpl4net.Client.Models.PathOrderBook
{
    public class BookOffersRequest : BaseRequest
    {
        public override string method => "book_offers";

        [JsonProperty("params")]
        public BookOffersRequestParams Params { get; set; }
    }

    public class BookOffersRequestParams : BaseRequestParams
    {
        public string taker { get; set; }

        public TakerGets taker_gets { get; set; }

        public TakerPays taker_pays { get; set; }
    }

    public class TakerGets
    {
        public string currency { get; set; }
    }

    public class TakerPays
    {
        public string currency { get; set; }

        public string issuer { get; set; }
    }
}
