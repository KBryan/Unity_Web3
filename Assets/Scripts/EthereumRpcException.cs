﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainGame
{
    public class EthereumRpcException : Exception
    {
        public EthereumRpcException(string message) : base(message)
        {

        }
    }
}
