using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient
{
    public class SolarApiResponseHeader
    {
        public Dictionary<string,string> RequestArguments { get; set; }
        public SolarApiResponseHeaderStatus Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
