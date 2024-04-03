using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductName()
        {
            return Ok("Product Name API Success");
        }
    }
}
