using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// An http post request to print the text Who's There
        /// </summary>
        /// <returns>
        /// output is the "Who's There" string
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock  ->  Who's there?
        /// </example>
        [HttpPost(template:"knockknock")]
        public string knockknock()
        {
            return "Who's There?";
        }
    }
}
