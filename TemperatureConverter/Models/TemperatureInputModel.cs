using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConverter.Models
{
    public class TemperatureInputModel
    {
        public int Format { get; set; }
        public float TempValue { get; set; }
    }
}
