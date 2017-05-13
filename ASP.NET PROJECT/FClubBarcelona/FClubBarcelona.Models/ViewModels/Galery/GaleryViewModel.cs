namespace FClubBarcelona.Models.ViewModels.Galery
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class GaleryViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string ImageTitle { get; set; }

        [Required]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }
    }
}
