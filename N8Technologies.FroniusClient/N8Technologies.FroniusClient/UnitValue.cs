using System;
using System.Collections.Generic;
using System.Text;

namespace N8Technologies.FroniusClient
{
    public class UnitValue<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public UnitValue()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public UnitValue(string unit, T value)
        {
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Create a new UnitValue, setting the unit, but no value
        /// </summary>
        /// <param name="unit"></param>
        public UnitValue(string unit)
        {
            this.Unit = unit;
        }

        /// <summary>
        /// Unit name
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Unit value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Provides a string representation of the Unit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Value} {Unit}";
        }
    }
}
