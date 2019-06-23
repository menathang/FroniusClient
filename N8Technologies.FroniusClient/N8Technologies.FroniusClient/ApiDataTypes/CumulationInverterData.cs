using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace N8Technologies.FroniusClient.ApiDataTypes
{
    public class CumulationInverterData
    {
        [JsonProperty("PAC")]
        public UnitValue<int> AcPower { get; set; }
        [JsonProperty("DAY_ENERGY")]
        public UnitValue<decimal> CurentDayEnergy { get; set; }
        [JsonProperty("YEAR_ENERGY")]
        public UnitValue<decimal> CurrentYearEnergy { get; set; }
        [JsonProperty("TOTAL_ENERGY")]
        public UnitValue<decimal> TotalEnergy { get; set; }

        public DeviceStatus DeviceStatus { get; set; }
    }
}
