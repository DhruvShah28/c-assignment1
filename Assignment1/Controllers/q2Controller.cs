using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// receive a name from user and print Hi! message with given name printed
        /// </summary>
        /// <param name="name">
        /// name is the string that user would enter
        /// </param>
        /// <returns>
        /// message on cli "Hi! {name}"
        /// </returns>
        /// <example>
        ///GET api/q1/greeting ->  Hi Dhruv Shah!
        ///GET api/q1/greeting ->  Hi abc xyz!
        ///GET api/q1/greeting ->  Hi Shruv Shah!
        /// </example>
        [HttpGet(template: "greeting")]

        public string greeting(string name)
        {
            return $"Hi {name}!";
        } 
    }
}