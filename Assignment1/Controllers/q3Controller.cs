using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Print the cube of the number given in input
        /// </summary>
        /// <param name="Base">base is the number input by the user</param>
        /// <returns>
        /// An http response to print out the cube of the number entered by the user
        /// </returns>
        /// <example>
        /// GET api/q3/cube/4  ->  64
        /// GET api/q3/cube/-4  ->  -64
        /// GET api/q3/cube/10  ->  1000
        /// </example>
        [HttpGet(template:"cube/{Base}")]
        public int cube(int Base)
        {
            return (int)Math.Pow(Base, 3);
        }
    }
}
