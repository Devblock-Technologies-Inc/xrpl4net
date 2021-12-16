using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models.PathOrderBook
{
    public class BookOffersResponse : BaseResponse
    {
        public BookOffersResult result { get; set; }
    }

    public class BookOffersResult
    {

    }
}
