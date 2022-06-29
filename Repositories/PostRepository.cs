using Newtonsoft.Json;
using Project.Models;
namespace Project.Repositories
{
    public class PostRepository
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            IEnumerable<Post>? data = JsonConvert.DeserializeObject<IEnumerable<Post>>(response);

            if (data != null)
                return data;

            return new List<Post>();
        }

        public async Task<Post> GetPost(int ID)
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/" + ID);
            Post? data = JsonConvert.DeserializeObject<Post>(response);

            if (data != null)
                return data;

            return new Post();
        }
    }
}
