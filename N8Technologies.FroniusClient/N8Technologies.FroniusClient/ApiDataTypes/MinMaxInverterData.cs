using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient.ApiDataTypes
{
    public class MinMaxInverterData
    {
        [JsonProperty("DAY_PMAX")]
        public UnitValue<int> MaxCurrentDayAcPower { get; set; }
        [JsonProperty("DAY_UACMAX")]
        public UnitValue<decimal> MaxCurrentDayAcVoltage { get; set; }
        [JsonProperty("DAY_UACMIN")]
        public UnitValue<decimal> MinCurrentDayAcVoltage { get; set; }
        [JsonProperty("DAY_UDCMAX")]
        public UnitValue<decimal> MaxCurrentDayDcVoltage { get; set; }
        [JsonProperty("YEAR_PMAX")]
        public UnitValue<int> MaxCurrentYearAcPower { get; set; }
        [JsonProperty("YEAR_UACMAX")]
        public UnitValue<decimal> MaxCurrentYearAcVoltage { get; set; }
        [JsonProperty("YEAR_UACMIN")]
        public UnitValue<decimal> MinCurrentYearAcVoltage { get; set; }
        [JsonProperty("YEAR_UDCMAX")]
        public UnitValue<decimal> MaxCurrentYearDcVoltage { get; set; }
        [JsonProperty("TOTAL_PMAX")]
        public UnitValue<int> MaxTotalAcPower { get; set; }
        [JsonProperty("TOTAL_UACMAX")]
        public UnitValue<decimal> MaxTotalAcVoltage { get; set; }
        [JsonProperty("TOTAL_UACMIN")]
        public UnitValue<decimal> MinTotalAcVoltage { get; set; }
        [JsonProperty("TOTAL_UDCMAX")]
        public UnitValue<decimal> MaxTotalDcVoltage { get; set; }

    }
}
