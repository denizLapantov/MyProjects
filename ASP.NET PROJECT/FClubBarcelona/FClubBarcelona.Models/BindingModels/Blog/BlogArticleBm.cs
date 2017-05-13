namespace FClubBarcelona.Models.BindingModels.Blog
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class BlogArticleBm
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DisplayName("Start Article Title")]
        public string StartArticle { get; set; }

        [Required]
        [DisplayName("Image")]
        public string ImageTitle { get; set; }

        [Required]
        [DisplayName("Video")]
        public string YouTubeUrl { get; set; }

    }
}
