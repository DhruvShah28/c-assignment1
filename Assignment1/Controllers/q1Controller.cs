using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// Receive an HTTP get request and provide a message
        /// </summary>
        /// <returns>
        /// message on cli "Welcome to 5125"
        /// </returns>
        /// <example>
        ///GET api/q1/welcome ->  Welcome to 5125
        /// </example>
        [HttpGet(template: "welcome")]

        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
