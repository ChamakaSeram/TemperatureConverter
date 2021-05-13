using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConverter.Enum
{
    public class TemperatureConverterEnum
    {
        public enum ApiResponseEnum
        {
            Success = 1,
            Error = 2,
            SessionExpired = 3,
            Approval = 4,
            Warning = 5
        }

        public enum TempFormatEnum
        {
            CelsiusToKelvin = 12,
            CelsiusToFahrenheit = 13,
            KelvinToCelsius = 21,
            KelvinToFahrenheit = 23,
            FahrenheitToCelsius = 31,
            FahrenheitToKelvin = 32
        }
    }
}
