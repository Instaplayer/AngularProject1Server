using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Route("/CoolerValues")]
    [ApiController]

    public class CoolValuesController : ControllerBase
    {
        public int rng = Random.Shared.Next(3, 10);
        
        [HttpGet(Name = "GetValues")]
        public IEnumerable<CoolerValues> Get()
        {
            
            return Enumerable.Range(1, rng).Select(index => new CoolerValues
            {
                ValName = "value" + index,
                Val = Random.Shared.Next(0, 100)

            }).ToArray();

        }

        [HttpPost(Name = "PostValues")]
        public IEnumerable<CoolerValues> Post()
        {

            return Enumerable.Range(1, rng).Select(index => new CoolerValues
            {
                ValName = "value" + (index * 2),
                Val = Random.Shared.Next(0, 100)

            }).ToArray();

        }

        /*
        public CoolerValues Post(CoolerValues message)
        {
            message.ValName = "value" + rng;
            message.Val = 10;

            return message;
        }
        */


        [HttpPut(Name = "PutValues")]
        /*
        public CoolerValues Put()
        {

            message = new CoolerValues();
            message.ValName = "value";
            message.Val = Random.Shared.Next(0, 100);

           

            return message;
        }
        */

        public IEnumerable<CoolerValues> Put()
        {

            return Enumerable.Range(1, rng).Select(index => new CoolerValues
            {
                ValName = "value" + (index * 3),
                Val = Random.Shared.Next(0, 100)

            }).ToArray();

        }

        [HttpPatch(Name = "PatchValues")]
        /*
        public CoolerValues Patch(CoolerValues message)
        {

            message.ValName = "value" + rng;
            message.Val = Random.Shared.Next(0, 100);

            return message;
        }
        */

        public IEnumerable<CoolerValues> Patch()
        {

            return Enumerable.Range(1, rng).Select(index => new CoolerValues
            {
                ValName = "value" + (index * 5),
                Val = Random.Shared.Next(0, 100)

            }).ToArray();

        }

    }
}
