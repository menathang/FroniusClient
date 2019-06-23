using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient
{
    public class CommonInverterData
    {
        [JsonProperty("DAY_ENERGY")]
        public UnitValue<decimal> CurrentDayEnergy { get; set; }
        [JsonProperty("TOTAL_ENERGY")]
        public UnitValue<decimal> TotalEnergy { get; set; }
        [JsonProperty("YEAR_ENERGY")]
        public UnitValue<decimal> CurrentYearEnergy { get; set; }
        [JsonProperty("PAC")]
        public UnitValue<int> AcPower { get; set; }
        [JsonProperty("IAC")]
        public UnitValue<decimal> AcCurrent { get; set; }
        [JsonProperty("UAC")]
        public UnitValue<decimal> AcVoltage { get; set; }
        [JsonProperty("FAC")]
        public UnitValue<decimal> AcFrequency { get; set; }
        [JsonProperty("IDC")]
        public UnitValue<decimal> DcCurrent { get; set; }
        [JsonProperty("UDC")]
        public UnitValue<decimal> DcVoltage { get; set; }
        public DeviceStatus DeviceStatus { get; set; }
    }
}
