using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.KeyGeneration
{
    public class ValidationCreateRequest : BaseRequest
    {
        public override string method => "validation_create";

        [JsonProperty("params")]
        public ValidationCreateRequestParams[] Params { get; set; }
    }

    public class ValidationCreateRequestParams
    {
        public string secret { get; set; }
    }
}
