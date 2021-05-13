using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConverter;
using TemperatureConverter.Services;
using static TemperatureConverter.Enum.TemperatureConverterEnum;

namespace TemperatureConverterTest
{
    [TestClass]
    public class TempConvertTest
    {
        TemperatureConverterService tempService;

        public TempConvertTest()
        {
            tempService = new TemperatureConverterService();
        }

        [TestMethod]
        public void Test_ConvertFromCelsiusToFahrenheitMethod()
        {
            float celsiusValue = 10;
            float expectedResult = 50;

            var result = tempService.ConvertFromCelsiusToFahrenheit(celsiusValue);

            Assert.AreEqual(expectedResult, result, "Wrongly converted from celsius to fahrenheit");
        }

        [TestMethod]
        public void Test_ConvertFromCelsiusToKelvinMethod()
        {
            float celsiusValue = 10;
            float expectedResult = 283.15F;

            var result = tempService.ConvertFromCelsiusToKelvin(celsiusValue);

            Assert.AreEqual(expectedResult, result, 0.01, "Wrongly converted from celsius to kelvin");
        }

        [TestMethod]
        public void Test_ConvertFromKelvinToFahrenheitMethod()
        {
            float kelivnValue = 10;
            float expectedResult = -441.67F;

            var result = tempService.ConvertFromKelvinToFahrenheit(kelivnValue);

            Assert.AreEqual(expectedResult, result, 0.01, "Wrongly converted from kelvin to fahrenheit");
        }

        [TestMethod]
        public void Test_ConvertFromKelvinToCelsiusMethod()
        {
            float kelivnValue = 10;
            float expectedResult = -263.15F;

            var result = tempService.ConvertFromKelvinToCelsius(kelivnValue);

            Assert.AreEqual(expectedResult, result, 0.01, "Wrongly converted from kelvin to celsius");
        }

        [TestMethod]
        public void Test_ConvertFromFahrenheitToKelvinMethod()
        {
            float fahrenheitValue = 10;
            float expectedResult = 260.928F;

            var result = tempService.ConvertFromFahrenheitToKelvin(fahrenheitValue);

            Assert.AreEqual(expectedResult, result, 0.01, "Wrongly converted from fahrenheit to kelivin");
        }

        [TestMethod]
        public void Test_ConvertFromFahrenheitToCelsiusMethod()
        {
            float fahrenheitValue = 10;
            float expectedResult = -12.22F;

            var result = tempService.ConvertFromFahrenheitToCelsius(fahrenheitValue);

            Assert.AreEqual(expectedResult, result, 0.01, "Wrongly converted from fahrenheit to celsius");
        }

    }
}
