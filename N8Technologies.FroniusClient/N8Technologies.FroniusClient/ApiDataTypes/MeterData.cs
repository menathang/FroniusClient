using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient.ApiDataTypes
{
    public class MeterData
    {
        public DateTime Timestamp { get; set; }
        public int Enable { get; set; }
        public int Visible { get; set; }
        public decimal NetPowerAllPhases { get; set; }
        public decimal NetPowerPhaseA { get; set; }
        public decimal NetPowerPhaseB { get; set; }
        public decimal NetPowerPhaseC { get; set; }
        public decimal ReactivePowerAllPhases { get; set; }
        public decimal ReactivePowerPhaseA { get; set; }
        public decimal ReactivePowerPhaseB { get; set; }
        public decimal ReactivePowerPhaseC { get; set; }
        public decimal AcCurrentPhaseA { get; set; }
        public decimal AcCurrentPhaseB { get; set; }
        public decimal AcCurrentPhaseC { get; set; }
        public decimal AcVoltagePhaseA { get; set; }
        public decimal AcVoltagePhaseB { get; set; }
        public decimal AcVoltagePhaseC { get; set; }
        public decimal AcVoltagePhaseAToB { get; set; }
        public decimal AcVoltagePhaseBToC { get; set; }
        public decimal AcVoltagePhaseCToA { get; set; }
        public decimal AveragePhaseFrequency { get; set; }
        public decimal ApparentPower { get; set; }
        public decimal PowerFactorPhaseA { get; set; }
        public decimal PowerFactorPhaseB { get; set; }
        public decimal PowerFactorPhaseC { get; set; }
        public decimal RealEnergyProduced { get; set; }
        public decimal RealEnergyConsumed { get; set; }
        public decimal ReactiveEnergyProduced { get; set; }
        public decimal ReactiveEnergyConsumed { get; set; }
        public decimal PlusEnergyAbsolute { get; set; }
        public decimal MinusEnergyAbsolute { get; set; }

    }
}
