using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient.ApiDataTypes
{
    public class ThreePhaseInverterData
    {
        [JsonProperty("IAC_L1")]
        public UnitValue<decimal> PhaseAAcCurrent { get; set; }
        [JsonProperty("IAC_L2")]
        public UnitValue<decimal> PhaseBAcCurrent { get; set; }
        [JsonProperty("IAC_L3")]
        public UnitValue<decimal> PhaseCAcCurrent { get; set; }
        [JsonProperty("UAC_L1")]
        public UnitValue<decimal> PhaseAAcVoltage { get; set; }
        [JsonProperty("UAC_L2")]
        public UnitValue<decimal> PhaseBAcVoltage { get; set; }
        [JsonProperty("UAC_L3")]
        public UnitValue<decimal> PhaseCAcVoltage { get; set; }
        [JsonProperty("T_AMBIENT")]
        public UnitValue<int> AmbientTemp { get; set; }
        [JsonProperty("ROTATION_SPEED_FAN_FL")]
        public UnitValue<decimal> FanFrontLeftSpeed { get; set; }
        [JsonProperty("ROTATION_SPEED_FAN_FR")]
        public UnitValue<decimal> FanFrontRightSpeed { get; set; }
        [JsonProperty("ROTATION_SPEED_FAN_BL")]
        public UnitValue<decimal> FanBackLeftSpeed { get; set; }
        [JsonProperty("ROTATION_SPEED_FAN_BR")]
        public UnitValue<decimal> FanBackRightSpeed { get; set; }
    }
}
