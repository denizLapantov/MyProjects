namespace FClubBarcelona.Models.ViewModels.Coaches
{
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class AllCoachesVm
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Video")]
        public string ImageUrl { get; set; }

    }
}
