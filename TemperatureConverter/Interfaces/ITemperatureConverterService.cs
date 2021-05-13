using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConverter.Models;

namespace TemperatureConverter.Interfaces
{
    public interface ITemperatureConverterService
    {
        ITemperatureAPIResponse ConvertTemperature(TemperatureInputModel model);
    }
}
