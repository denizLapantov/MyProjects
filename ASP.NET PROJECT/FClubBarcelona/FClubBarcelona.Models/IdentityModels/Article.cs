namespace FClubBarcelona.Models.IdentityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string StartArticle { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [Required]
        public string ImageTitle { get; set; }

        [Required]
        public string YouTubeUrl { get; set; }
    }
}
