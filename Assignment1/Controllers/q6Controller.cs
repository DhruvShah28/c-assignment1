using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// An http get request to get a side of a hexagon as number input from tbe user and give the output as area of hexagon 
        /// </summary>
        /// <param name="side">an int parameter used to get the side of a hexagon from user</param>
        /// <remarks>
        /// we have used double for hexagon as we want the output as decimal
        /// </remarks>
        /// <returns>
        /// An HTTP get response as the area of regular hexagon of side {S}.
        /// </returns>
        /// <example>
        /// GET api/q6/hexagon?side=1  ->  2.598076211353316
        /// GET api/q6/hexagon?side=1.5  ->  5.845671475544961
        /// GET api/q6/hexagon?side=2  ->  10.392304845413264
        /// </example>

        [HttpGet (template:"hexagon")]
        public double hexagon(double side)
        {
            return (double)((double)(3 * Math.Sqrt(3) /2) * (Math.Pow(side, 2)));
        }
    }
}
