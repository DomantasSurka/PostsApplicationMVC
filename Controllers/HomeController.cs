using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Diagnostics;
using Project.Services;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostService _postService = new();

        [HttpGet]
        public IActionResult Index(int? page, string sortBy, string filter)
        {
            IEnumerable<Post> postsData = _postService.GetPosts();
           
            if (!String.IsNullOrEmpty(filter))
                postsData = postsData.Where(p => p.UserID.Equals(Int32.Parse(filter)));

            ViewData["IDSortParm"] = String.IsNullOrEmpty(sortBy) ? "id_desc" : "";
            ViewData["UserIDSortParm"] = sortBy == "userid_desc" ? "userid" : "userid_desc";
            ViewData["TitleSortParm"] = sortBy == "title_desc" ? "title" : "title_desc";
            ViewData["BodySortParm"] = sortBy == "body_desc" ? "body" : "body_desc";
            ViewData["CurrentSort"] = sortBy;
            ViewData["CurrentFilter"] = filter;

            postsData = _postService.SortPostsList(postsData, sortBy);

            return View(PaginatedList<Post>.Create(postsData, page ?? 1, 5));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_postService.GetPost(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(Post post)
        {
            return String.Format("UserID: {0}\nID: {1}\nTitle: \"{2}\"\nBody: \"{3}\"", post.UserID, post.ID, post.Title, post.Body);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}