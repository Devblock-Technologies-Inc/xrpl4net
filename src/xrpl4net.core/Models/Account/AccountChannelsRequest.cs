using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	/// <summary>
	/// The account_channels method returns information about an account's Payment
	/// Channels. This includes only channels where the specified account is the
	/// channel's source, not the destination. (A channel's "source" and "owner" are
	/// the same.) All information retrieved is relative to a particular version of
	/// the ledger. Returns an {@link AccountChannelsResponse}.
	/// </summary>
	public class AccountChannelsRequest : BaseRequest
	{
		public override string MethodInfo => "account_channels";

		/// <summary>
		/// The unique identifier of an account, typically the account's address. The
		/// request returns channels where this account is the channel's owner/source.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Account { get; set; }

		/// <summary>
		/// The unique identifier of an account, typically the account's address. If
		/// provided, filter results to payment channels whose destination is this
		/// account.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("destination_account", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string DestinationAccount { get; set; }

		/// <summary>
		/// The ledger index of the ledger to use, or a shortcut string to choose a
		/// ledger automatically.
		/// </summary>
		[Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public LedgerIndex LedgerIndex { get; set; }

	}
}
