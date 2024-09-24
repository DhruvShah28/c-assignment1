using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// An http get request to add user entered number to the current date
        /// </summary>
        /// <param name="days">it is used to save the user entered number</param>
        /// <returns>
        /// it return date with the added number of day in "yyyy-MM-dd" format
        /// </returns>
        /// <remarks>
        /// capital MM is used to represent month in datetime format 
        /// </remarks>
        /// <example>
        /// GET api/q7/timemachine?days=1  -> tomorrow's date i.e.
        /// GET api/q7/timemachine?days=4  -> date after 4 days i.e.
        /// GET api/q7/timemachine?days=-1  -> yesterday's date i.e.
        /// </example>
        [HttpGet (template:"timemachine")]
        public string timemachine(int days)
        {
            DateTime today = DateTime.Now;
            DateTime ans = today.AddDays(days);

            return ans.ToString("yyyy-MM-dd");
        }
    }
}
