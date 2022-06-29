using Project.Models;
using Project.Repositories;
namespace Project.Services
{
    public class PostService
    {
        private readonly PostRepository _repository = new();
        public IEnumerable<Post> GetPosts() => _repository.GetPosts().Result;
        public Post GetPost(int id) => _repository.GetPost(id).Result;

        public IEnumerable<Post> SortPostsList(IEnumerable<Post> posts, string sortBy)
        {
            posts = sortBy switch
            {
                "body_desc" => posts.OrderByDescending(p => p.Body),
                "body" => posts.OrderBy(p => p.Body),
                "title_desc" => posts.OrderByDescending(p => p.Title),
                "title" => posts.OrderBy(p => p.Title),
                "userid_desc" => posts.OrderByDescending(p => p.UserID),
                "userid" => posts.OrderBy(p => p.UserID),
                "id_desc" => posts.OrderByDescending(p => p.ID),
                _ => posts.OrderBy(p => p.ID),
            };
            return posts;
        }
    }
}
