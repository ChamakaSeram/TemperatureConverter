using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConverter.Interfaces;

namespace TemperatureConverter.Services
{
    public class TemperatureAPIResponse: ITemperatureAPIResponse
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public TemperatureAPIResponse GenerateResponseMessage(string statusCode, string message, object data)
        {
            this.StatusCode = statusCode;
            this.Message = message;
            this.Data = data;
            return this;
        }
    }
}
