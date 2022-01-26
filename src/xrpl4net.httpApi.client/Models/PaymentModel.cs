namespace xrpl4net.httpApi.client.Models
{
    public class PaymentModel
    {
        public string Account { get; set; }

        public long Amount { get; set; }

        public string Destination { get; set; }

        public string Fee { get; set; }

        public uint Flags { get; set; }

        public int Sequence { get; set; }

        public string TransactionType { get; set; }
    }
}
