using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	public abstract class BaseResponse
	{
		public BaseResponse(string requestId, short apiVersion = 1, bool forwarded = false,
		string status = "success", string type = "response", string warning = "load")
		{
			Id = requestId;
			Status = status;
			Type = type;
			Warning = warning;
			Forwarded = forwarded;
			ApiVersion = apiVersion;
		}

		public string Id { get; }
		public string Status { get; } = "success";
		public string Type { get; } = "response";
		public string Warning { get; } = "load";
		public List<Warning> Warnings { get; } = new List<Warning>();
		public bool Forwarded { get; }
		public short ApiVersion { get; }

		/// <summary>
		/// Value from a previous paginated response. Resume retrieving data where
		/// that response left off.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("marker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public object Marker { get; set; }
	}
}
