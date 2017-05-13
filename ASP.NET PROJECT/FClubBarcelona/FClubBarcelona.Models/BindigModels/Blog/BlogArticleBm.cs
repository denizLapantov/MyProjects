using System.ComponentModel.DataAnnotations;

namespace FClubBarcelona.Models.BindigModels.Blog
{
    public class BlogArticleBm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string StartArticle { get; set; }

        [Required]
        public string ImageTitle { get; set; }
    }
}
