using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConverter.Interfaces;
using TemperatureConverter.Models;

namespace TemperatureConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureConverterController : ControllerBase
    {
        private readonly ITemperatureConverterService service;

        public TemperatureConverterController(ITemperatureConverterService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("ConvertTemperature")]
        public ITemperatureAPIResponse ConvertTemperature(TemperatureInputModel model)
        {
            return service.ConvertTemperature(model);
        }
    }
}
