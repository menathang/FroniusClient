using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient
{
    public class SolarApiResponse<T>
    {
        public SolarApiResponseHeader Head { get; set; }

        public SolarApiResponseBody<T> Body { get; set; }
    }
}
