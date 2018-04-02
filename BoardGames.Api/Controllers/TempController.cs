using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BoardGames.Api.Controllers
{
    public class TempController : Controller
    {
        private readonly IConfiguration _configuration;

        public TempController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This is just a sample implementation for a demo, DO NOT use in production!!!
        [AllowAnonymous]
        [Route("/get-token")]
        public IActionResult GenerateToken(string name = "dockertalk")
        {
            var jwt = JwtTokenGenerator
                .Generate(name, true, _configuration["Tokens:Issuer"], _configuration["Tokens:Key"]);

            return Ok(jwt);
        }
    }
}
