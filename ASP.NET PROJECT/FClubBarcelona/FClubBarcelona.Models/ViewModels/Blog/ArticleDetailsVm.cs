namespace FClubBarcelona.Models.ViewModels.Blog
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ArticleDetailsVm
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DisplayName("Start Article")]
        public string StartArticle { get; set; }

        [Required]
        [DisplayName("Publish Date")]
        public DateTime PublishDate { get; set; }

 
        [DisplayName("Athor")]
        public string Autor { get;set; }

        [Required]
        [DisplayName("Image")]
        public string ImageTitle { get; set; }

        [Required]
        [DisplayName("Video")]
        public string YouTubeUrl { get; set; }
    }
}
