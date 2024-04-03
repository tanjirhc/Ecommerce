using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductAPIController : Controller
    {
        public IActionResult LisProduct()
        {
            List<Product> lstPoducts = new List<Product>();
            Product product = new Product();
            product.Name = "Laptop 1";
            product.Picture = "https://media.istockphoto.com/id/1266659893/vector/blank-white-screen-laptop-isolated.jpg?s=612x612&w=0&k=20&c=rrRWxOtMQ6NBLg1tgNJPhdLNJkiAgGPrJhruyuKclYc=";
            product.Price = 100;
            product.Quantity = 10;
            lstPoducts.Add(product);

            product = new Product();
            product.Name = "Laptop 2";
            product.Picture = "https://media.istockphoto.com/id/1266659893/vector/blank-white-screen-laptop-isolated.jpg?s=612x612&w=0&k=20&c=rrRWxOtMQ6NBLg1tgNJPhdLNJkiAgGPrJhruyuKclYc=";
            product.Price = 100;
            product.Quantity = 10;
            lstPoducts.Add(product);

            product = new Product();
            product.Name = "Laptop 3";
            product.Picture = "https://media.istockphoto.com/id/1266659893/vector/blank-white-screen-laptop-isolated.jpg?s=612x612&w=0&k=20&c=rrRWxOtMQ6NBLg1tgNJPhdLNJkiAgGPrJhruyuKclYc=";
            product.Price = 100;
            product.Quantity = 10;
            lstPoducts.Add(product);


            return Ok(lstPoducts);
        }
    }
}
