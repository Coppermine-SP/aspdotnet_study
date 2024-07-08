using System.ComponentModel.DataAnnotations;

namespace Cg1119ProfileBlog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        
        public string? Title { get; set; }
        public string? Contents { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
