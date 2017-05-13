namespace FClubBarcelona.Models.ViewModels.Coaches
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class CoachDetailsVm
    {
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

        [Required]
        [DisplayName("Video")]
        public string VideoUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        [DisplayName("Coach Years")]
        public string CoachYears { get; set; }
    }
}
