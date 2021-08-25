﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChainGame
{
    public class ConnectionOptions : MonoBehaviour
    {
        public string Url { get; set; }
        public string Port { get; set; }
        public int TimeOut { get; set; }
        public NetworkCredential NetworkCredential { get; set; }
        public WebProxy Proxy { get; set; }
        public string FullUrl => string.Format("{0}:{1}", Url, Port);
        public bool IsUrlValid => FullUrl.IsUri();

        public ConnectionOptions()
        {
            TimeOut = 5000;
        }
    }
}
