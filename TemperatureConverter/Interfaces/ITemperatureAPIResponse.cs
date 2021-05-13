using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConverter.Services;

namespace TemperatureConverter.Interfaces
{
    public interface ITemperatureAPIResponse
    {
        TemperatureAPIResponse GenerateResponseMessage(string statusCode, string message, object data);
    }
}
