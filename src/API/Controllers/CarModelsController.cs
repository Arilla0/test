using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.OData;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarModelsController : ControllerBase
    {
        private readonly ILogger<CarModelsController> _logger;

        public CarModelsController(ILogger<CarModelsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery()]
        public IEnumerable<CarModels> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index =>
                {
                    var name = Data.CarNames[rng.Next(Data.CarNames.Length - 1)];
                    var car = new CarModels
                    {
                        ID = index,
                        Name = name,
                        BrandName = name + " Inc.",
                        isAvailable = Convert.ToBoolean(rng.Next(2))
                    };
                    return car;
                })
            .ToArray();
        }
    }
}
