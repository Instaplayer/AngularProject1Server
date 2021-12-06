using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;


namespace WebApplication1.Controllers
{

    [Route("/PostBase")]
    [ApiController]
    public class PostController : Controller
    {

        [HttpGet(Name = "GrabPosts")]
        public IEnumerable<Posts> GetPost()
        {
            List<Posts> PostsDB = new List<Posts>();
            PostsDB.Add(new Posts() { PostId = 1, PostTitle = "My first Post :D" });
            PostsDB.Add(new Posts() { PostId = 2, PostTitle = "My second Post ~0_0~" });

            return PostsDB.Where(c => c.PostId != null).ToArray();
        }

        
    }
}
