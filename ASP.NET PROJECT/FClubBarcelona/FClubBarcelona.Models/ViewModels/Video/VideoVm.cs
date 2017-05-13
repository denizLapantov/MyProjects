namespace FClubBarcelona.Models.ViewModels.Video
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class VideoVm
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Video")]
        public string VideoUrl { get; set; }

        [Required]
        public string Duration { get; set; }
    }
}
