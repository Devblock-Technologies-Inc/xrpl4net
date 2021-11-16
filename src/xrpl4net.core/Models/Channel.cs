using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	public class Channel
	{
		[JsonProperty("account")]
		public string Account { get; set; }

		[JsonProperty("amount")]
		public string Amount { get; set; }

		[JsonProperty("balance")]
		public string Balance { get; set; }

		[JsonProperty("channel_id")]
		public string ChannelId { get; set; }

		[JsonProperty("destination_account")]
		public string DestinationAccount { get; set; }

		[JsonProperty("destination_tag")]
		public int DestinationTag { get; set; }

		[JsonProperty("public_key")]
		public string PublicKey { get; set; }

		[JsonProperty("public_key_hex")]
		public string PublicKeyHex { get; set; }

		[JsonProperty("settle_delay")]
		public int SettleDelay { get; set; }
	}
}
