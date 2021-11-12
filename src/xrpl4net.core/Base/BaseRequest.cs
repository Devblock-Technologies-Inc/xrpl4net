using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	public abstract class BaseRequest
	{
		public BaseRequest(short apiVersion = 1)
		{
			Id = Guid.NewGuid().ToString();
			ApiVersion = apiVersion;
		}

		/// <summary>
		///  A unique value to identify this request. The response to this request uses the same id field.This way, even if responses arrive out of order, you 
		///  know which request prompted which response.
		/// </summary>
		public string Id { get; }

		/// <summary>
		/// The API version to use. If omitted, use version 1.
		/// </summary>
		public short ApiVersion { get; }

		/// <summary>
		/// The name of the API method
		/// </summary>
		public virtual string MethodInfo { get; }

		/// <summary>
		/// Limit the number of transactions to retrieve. Cannot be less than 10 or
		/// more than 400. The default is 200.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? Limit { get; set; }

		/// <summary>
		/// Value from a previous paginated response. Resume retrieving data where
		/// that response left off.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("marker", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public object Marker { get; set; }
	}
}
