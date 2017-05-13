using Microsoft.Build.Framework;

namespace FClubBarcelona.Models.IdentityModels
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public string Duration { get; set; }
    }
}
