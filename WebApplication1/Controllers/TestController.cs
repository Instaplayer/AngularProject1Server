using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet(Name = "GetNames")]
        public IEnumerable<string> Get() { 
            return new List<string>()
            {
                "Jakub",
                "Miss Sara",
                "King Kong"
            }; 
        }




    }
}
