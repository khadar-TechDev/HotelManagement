using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Server.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EchoTestController : ControllerBase
    {
        [HttpGet,Route("EchoTest")]
        public string GetTest()
        {
            return $"Test Passed Modified";
        }
    }
}
