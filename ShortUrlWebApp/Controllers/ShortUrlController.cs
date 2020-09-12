using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShortUrlWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShortUrlController : ControllerBase
    {
        private readonly ILogger<ShortUrlController> _logger;

        public ShortUrlController(ILogger<ShortUrlController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ShortUrl Get(string url, bool regenrate)
        {
            var rng = new Random();

            // finally:
            // IF (regenrate is false) AND (url is in DB) {return from DB} ESLE {generate new and inseert into DB}
            // IF (regenrate is true) {generate new and inseert into DB}

            return new ShortUrl
            {
                Url = url,
                UrlEncoded = "endodedUrl" + rng.Next(),
                Created = DateTime.Now
            };
        }
    }
}
