using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	/// <summary>
	/// The shape of an error response from rippled.
	/// </summary>
	public class ErrorResponse<T>
	{
		public ErrorResponse(string requestId, T request, short apiVersion = 1,
		string status = "error", string type = "response", string errorCode = "", string errorMessage = "")
		{
			Id = requestId;
			Status = status;
			Type = type;
			ApiVersion = apiVersion;
			Request = request;
			ErrorCode = errorCode;
			ErrorMessage = errorMessage;
		}

		public string Id { get; }
		public string Status { get; } = "error";
		public string Type { get; } = "response";
		public string Error { get; }
		public string ErrorCode { get; }
		public string ErrorMessage { get; }
		public T Request { get; }
		public short ApiVersion { get; }

	}
}
