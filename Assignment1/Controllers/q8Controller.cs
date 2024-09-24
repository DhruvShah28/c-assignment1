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
        /// <param name="small">it saves the amount given in form</param>
        /// <param name="large">it saves the amount given in form</param>
        /// <returns></returns>
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
