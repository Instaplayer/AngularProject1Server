using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Route("/ngrx")]
    [ApiController]

    public class ngrxController : Controller
    {
        public static List<Products> ProductsDB = new List<Products>();

        [HttpGet(Name = "getProducts")]
        public IEnumerable<Products> getProducts(bool getSpecific, int? id)
        {

            if (getSpecific == true)
            {
                return ProductsDB.Where(c => c.id == id).ToArray();
            }
            else
            {
                return ProductsDB.Where(c => c.id != null).ToArray();
            }
            
        }

        [HttpPost(Name = "postProducts")]
        public Products postProducts(Products product)
        {
            product.id = ProductsDB.Where((c) => c.id != null).Count() + 1;
            ProductsDB.Add(product);

            return product;
        }

        [HttpDelete(Name = "delProducts")]
        public Products delProducts(int index)
        {
            Products del = ProductsDB[index];

            if(del != null) { 
                ProductsDB.Remove(del);
            }

            return del;
        }
    }
}
