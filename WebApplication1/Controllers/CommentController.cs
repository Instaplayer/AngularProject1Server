using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;


namespace WebApplication1.Controllers
{

    [Route("/CommentBase")]
    [ApiController]
    public class CommentController : Controller
    {
        public static List<Comments> CommentsDB = new List<Comments>();

        [HttpGet("{id}",Name = "GetPosts")]
        public IEnumerable<Comments> GetPosts(int  id)
        {

            return CommentsDB.Where(c => c.ParentId == id).ToArray();
        }


        [HttpPost("{id}",Name = "PostComment")]
        public Comments Post(Comments message, int id)
        {
            message.CommentId = (CommentsDB.Where(c => c.ParentId == id)).Count() + 1;
            message.ParentId = id;
            CommentsDB.Add(message);

            return message;
        }

        
    }
}
