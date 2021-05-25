using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger.Swashbuckle.Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class NewsBroadcastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Crime Summary", "Sports Summary", "Entertainment Summary", "Politics Summary", "Weather Summary", "Elections Summary", "Travel Summary", "International Summary", "Kids Summary", "Strange Summary"
        };

        private static readonly string[] HeadLines = new[]
        {
            "Crime", "Sports", "Entertainment", "Politics", "Weather", "Elections", "Travel", "International", "Kids", "Strange"
        };

        private readonly ILogger<NewsBroadcastController> _logger;

        public NewsBroadcastController(ILogger<NewsBroadcastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<NewsBroadcast> Get()
        {          
            return Enumerable.Range(0,10).Select(index => new NewsBroadcast
            {
                Date = DateTime.Now.AddDays(index),
                HeadLine = HeadLines[index],
                Summary = Summaries[index],
                id = index + 1
            })
            .ToArray();
        }

        [HttpPost]
        public NewsBroadcast Post(NewsBroadcast News)
        {
            return News;
        }

        
    }
}
