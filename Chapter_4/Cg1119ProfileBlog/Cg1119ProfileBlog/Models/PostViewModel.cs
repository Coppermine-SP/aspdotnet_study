namespace Cg1119ProfileBlog.Models
{
    public class PostsViewModel
    {
        public List<Post>? Posts { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}