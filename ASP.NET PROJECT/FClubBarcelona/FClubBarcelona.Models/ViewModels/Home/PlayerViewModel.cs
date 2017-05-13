namespace FClubBarcelona.Models.ViewModels.Home
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class PlayerViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }
    }
}
