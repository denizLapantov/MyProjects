namespace FClubBarcelona.Models.IdentityModels
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Build.Framework;

    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}