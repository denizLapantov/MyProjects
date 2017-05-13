namespace FClubBarcelona.Models.ViewModels.Blog
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Start Article")]
        public string StartArticle { get; set; }

        [Required]
        [DisplayName("Image")]
        public string ImageTitle { get; set; }
    }
}
