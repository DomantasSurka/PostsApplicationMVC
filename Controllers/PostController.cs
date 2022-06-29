using Microsoft.AspNetCore.Mvc;
using Project.Services;
using Project.Models;
namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostService _postService = new();

        // GET: api/post
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postService.GetPosts();
        }

        // GET: api/post/{ID}
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postService.GetPost(id);
        }

        // POST: api/post
        [HttpPost]
        public Post Post(Post post)
        {
            return post;
        }
    }
}
