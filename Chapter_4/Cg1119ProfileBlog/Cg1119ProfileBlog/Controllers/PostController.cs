using Cg1119ProfileBlog.Data;
using Cg1119ProfileBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cg1119ProfileBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private readonly AppDbContext _context;

        public PostController(ILogger<PostController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        //GET: Post/Index
        public IActionResult Index(int page = 1, int pageSize = 20)
        {
            var posts = _context.Posts
                .OrderBy(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            int total = _context.Posts.Count();
            var viewModel = new PostsViewModel
            {
                Posts = posts,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)total / pageSize)
            };

            return View(viewModel);
        }

        // GET: Post/Detail
        public IActionResult Detail(int id)
        {
            var posts = _context.Posts.FirstOrDefault(s => s.Id == id);
            if (posts == null)
            {
                return NotFound();
            }
            return View(posts);
        }

        [Authorize]
        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost(int id, Post model)
        {
            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Title = model.Title,
                    Contents = model.Contents,
                    CreatedAt = DateTime.Now
                };

                _context.Posts.Add(post);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Index");
        }
        // GET : Post/EditPost
        public IActionResult EditPost(int id)
        {
            var post = _context.Posts.FirstOrDefault(s => s.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(int id, Post model)
        {
            if (ModelState.IsValid)
            {
                var post = _context.Posts.FirstOrDefault(s => s.Id == id);
                if (post == null)
                {
                    return NotFound();
                }

                post.Title = model.Title;
                post.Contents = model.Contents;

                _context.Posts.Update(post);
                _context.SaveChanges();

                return RedirectToAction(nameof(Detail), new {id = post.Id});
            }

            return View(model);
        }
    }
}
