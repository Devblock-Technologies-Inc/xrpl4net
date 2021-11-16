using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	public class AccountChannelsResponse : BaseResponse
	{
		public AccountChannelsResponse(string requestId) : base(requestId)
		{ }

		/// <summary>
		/// The address of the source/owner of the payment channels. This corresponds to the account field of the request.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Account { get; set; }

		/// <summary>
		/// The ledger index of the ledger to use, or a shortcut string to choose a
		/// ledger automatically.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		LedgerIndex LedgerIndex { get; set; }

		/// <summary>
		/// If true, the information in this response comes from a validated ledger version.Otherwise, the information is subject to change.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		bool? Validated { get; set; }

		/// <summary>
		/// Payment channels owned by this account.
		/// </summary>
		public List<Channel> Channels { get; } = new List<Channel>();


	}
}
