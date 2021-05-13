using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConverter.Interfaces;
using TemperatureConverter.Models;
using static TemperatureConverter.Enum.TemperatureConverterEnum;

namespace TemperatureConverter.Services
{
    public class TemperatureConverterService : ITemperatureConverterService
    {
        private readonly ITemperatureAPIResponse temperatureAPIResponse;

        public TemperatureConverterService(ITemperatureAPIResponse temperatureAPIResponse)
        {
            this.temperatureAPIResponse = temperatureAPIResponse;
        }

        private double ConvertFromCelsiusToFahrenheit(float celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double ConvertFromCelsiusToKelvin(float celsius)
        {
            return celsius + 273.15;
        }

        private double ConvertFromKelvinToFahrenheit(float kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }

        private double ConvertFromKelvinToCelsius(float kelvin)
        {
            return kelvin - 273.15;
        }

        private double ConvertFromFahrenheitToKelvin(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }

        private double ConvertFromFahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public ITemperatureAPIResponse ConvertTemperature(TemperatureInputModel model)
        {
            double result = 0;

            switch (model.Format)
            {
                case (int)TempFormatEnum.CelsiusToKelvin:
                    result = ConvertFromCelsiusToKelvin(model.TempValue);
                    break;
                case (int)TempFormatEnum.CelsiusToFahrenheit:
                    result = ConvertFromCelsiusToFahrenheit(model.TempValue);
                    break;
                case (int)TempFormatEnum.KelvinToCelsius:
                    result = ConvertFromKelvinToCelsius(model.TempValue);
                    break;
                case (int)TempFormatEnum.KelvinToFahrenheit:
                    result = ConvertFromKelvinToFahrenheit(model.TempValue);
                    break;
                case (int)TempFormatEnum.FahrenheitToCelsius:
                    result = ConvertFromFahrenheitToCelsius(model.TempValue);
                    break;
                case (int)TempFormatEnum.FahrenheitToKelvin:
                    result = ConvertFromFahrenheitToKelvin(model.TempValue);
                    break;
                default:
                    result = model.TempValue;
                    break;
            }

            return temperatureAPIResponse.GenerateResponseMessage(ApiResponseEnum.Success.ToString(), String.Empty, result);
        }
    }
}
