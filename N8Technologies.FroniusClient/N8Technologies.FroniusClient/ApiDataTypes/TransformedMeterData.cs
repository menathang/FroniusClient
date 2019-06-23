using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient.ApiDataTypes
{
    public class TransformedMeterData
    {

        private MeterData MeterData { get; set; }

        public DateTime Timestamp { get; set; }
        public int Enable { get; set; }
        public int Visible { get; set; }
        public UnitValue<decimal> NetPowerAllPhases
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.NetPowerAllPhases };
            }
        }
        public UnitValue<decimal> NetPowerPhaseA
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.NetPowerPhaseA };
            }
        }

        public UnitValue<decimal> NetPowerPhaseB
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.NetPowerPhaseB };
            }
        }

        public UnitValue<decimal> NetPowerPhaseC
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.NetPowerPhaseC };
            }
        }

        public UnitValue<decimal> ReactivePowerAllPhases
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactivePowerAllPhases };
            }
        }

        public UnitValue<decimal> ReactivePowerPhaseA
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactivePowerPhaseA };
            }
        }

        public UnitValue<decimal> ReactivePowerPhaseB
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactivePowerPhaseB };
            }
        }

        public UnitValue<decimal> ReactivePowerPhaseC
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactivePowerPhaseC };
            }
        }

        public UnitValue<decimal> AcCurrentPhaseA
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "A", Value = MeterData.AcCurrentPhaseA };
            }
        }

        public UnitValue<decimal> AcCurrentPhaseB
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "A", Value = MeterData.AcCurrentPhaseB};
            }
        }

        public UnitValue<decimal> AcCurrentPhaseC
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "A", Value = MeterData.AcCurrentPhaseC };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseA
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseA };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseB
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseB };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseC
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseC };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseAToB
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseAToB };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseBToC
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseBToC };
            }
        }

        public UnitValue<decimal> AcVoltagePhaseCToA
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Vac", Value = MeterData.AcVoltagePhaseCToA };
            }
        }

        public UnitValue<decimal> AveragePhaseFrequency
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Hz", Value = MeterData.AveragePhaseFrequency };
            }
        }

        public UnitValue<decimal> ApparentPower
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ApparentPower };
            }
        }

        public decimal PowerFactorPhaseA
        {
            get
            {
                return MeterData.PowerFactorPhaseA;
            }
        }

        public decimal PowerFactorPhaseB
        {
            get
            {
                return MeterData.PowerFactorPhaseB;
            }
        }

        public decimal PowerFactorPhaseC
        {
            get
            {
                return MeterData.PowerFactorPhaseC;
            }
        }

        public UnitValue<decimal> RealEnergyProduced
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Wh", Value = MeterData.RealEnergyProduced };
            }
        }

        public UnitValue<decimal> RealEnergyConsumed
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "Wh", Value = MeterData.RealEnergyConsumed };
            }
        }

        public UnitValue<decimal> ReactiveEnergyProduced
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactiveEnergyProduced };
            }
        }

        public UnitValue<decimal> ReactiveEnergyConsumed
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.ReactiveEnergyConsumed };
            }
        }

        public UnitValue<decimal> PlusEnergyAbsolute
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.PlusEnergyAbsolute };
            }
        }

        public UnitValue<decimal> MinusEnergyAbsolute
        {
            get
            {
                return new UnitValue<decimal>() { Unit = "W", Value = MeterData.MinusEnergyAbsolute };
            }
        }

        /// <summary>
        /// Specifies a transformative version of meter data, which is
        /// enriched with static units for consistency
        /// </summary>
        /// <param name="data"></param>
        public TransformedMeterData(MeterData data)
        {
            this.MeterData = data;
        }

    }
}
