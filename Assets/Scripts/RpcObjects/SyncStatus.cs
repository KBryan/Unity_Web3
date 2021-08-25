using System;
using Newtonsoft.Json;

namespace ChainGame.RpcObjects
{
    public class SyncStatus
    {

        [JsonProperty(PropertyName = "startingBlock", Order = 0)]
        public string StartingBlock { get; set; }

        [JsonProperty(PropertyName = "currentBlock")]
        public string CurrentBlock { get; set; }

        [JsonProperty(PropertyName = "highestBlock", Order = 0)]
        public string HighestBlock { get; set; }

        public bool IsSyncing { get; set; }

        public SyncStatus()
        {
            
        }

        public override string ToString()
        {
            var toString = string.Empty;
            toString += "StartingBlock:{0}".FormatLine(StartingBlock);
            toString += "CurrentBlock:{0}".FormatLine(CurrentBlock);
            toString += "HighestBlock:{0}".FormatLine(HighestBlock);
            toString += "IsSyncing:{0}".FormatLine(IsSyncing);
            return toString;
        }
    }
}
