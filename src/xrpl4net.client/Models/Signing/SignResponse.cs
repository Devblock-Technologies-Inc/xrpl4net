﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models.Transactions;

namespace Xrpl4net.Client.Models.Signing
{
    public class SignResponse : BaseResponse
    {
        public SignResult result { get; set; }
    }

    public class SignResult
    {
        public string status { get; set; }
        public string tx_blob { get; set; }

        public TransactionDefinition tx_json { get; set; }
    }
}
