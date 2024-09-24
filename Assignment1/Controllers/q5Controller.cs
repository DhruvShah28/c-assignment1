using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// An http post request to get the number from the user and retrive and print it from the body
        /// </summary>
        /// <param name="number">the number input given by the user in the body of the data</param>
        /// <returns>
        /// an http response as "Shh... The number is {number}"
        /// </returns>
        /// <remarks>
        /// Heading: Content-Type: application/json
        /// </remarks>
        /// <example>
        /// POST api/q5/Secret  ->  "Shh.. the secret is 5" when -d 5 is sent as JSON in the body
        /// POST api/q5/Secret  ->  "Shh.. the secret is -200" when -d -200 is sent as JSON 
        /// POST api/q5/Secret  ->  "Shh.. the secret is 45" when -d 45 is sent as JSON 
        /// </example>
        [HttpPost(template:"secret")]
        public string secret([FromBody]int number)
        {
            return $"Shh.. The number is {number}";
        }
    }
}
