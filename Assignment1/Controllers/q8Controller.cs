using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        /// An Http post request to get the amount of large and small from our form and give the grand total price including item price, tax and the final price
        /// </summary>
        /// <param name="small">it saves the amount of small given in form</param>
        /// <param name="large">it saves the amount of large given in form</param>
        /// <returns>
        /// it return a string that consists of different int and string given in our body
        /// </returns>
        /// <example>
        /// POST api/q8/squashfellows  -> (when entered small as 1 and large as 1) 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
        /// POST api/q8/squashfellows  -> (when entered small as 2 and large as 1) 2 small @ 25.50 = $51.00; 1 Large @ 45.50 = $40.50; Subtotal = $91.50; Tax = $11.90; Total = $103.40
        /// POST api/q8/squashfellows  -> (when entered small as 1 and large as 1) 100 small @ 25.50 = $2,550.00; 100 Large @ 45.50 = $4,050.00; Subtotal = $6,600.00; Tax = $858.00; Total = $7,458.00
        /// </example>
        [HttpPost (template:"squashfellows")]
        public string squashfellows([FromForm] int small,[FromForm] int large)
        {
            double small_tot = small * 25.50;
            double large_tot = large * 40.50;
            double total_price = small_tot + large_tot;

            double tax = Math.Round(total_price * 0.13, 2);

            double grand_total = total_price + tax;

            var cultureinfo = new CultureInfo("en-CA");

            string small_tot_formatted = small_tot.ToString("C2", cultureinfo);
            string large_tot_formatted = large_tot.ToString("C2", cultureinfo);
            string total_price_formatted = total_price.ToString("C2", cultureinfo);
            string tax_formatted = tax.ToString("C2", cultureinfo);
            string grand_total_formatted = grand_total.ToString("C2", cultureinfo);

            return $"{small} small @ 25.50 = {small_tot_formatted}; {large} Large @ 45.50 = {large_tot_formatted}; Subtotal = {total_price_formatted}; Tax = {tax_formatted}; Total = {grand_total_formatted}";

        }
    }
}
