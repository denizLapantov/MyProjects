namespace FClubBarcelona.Models.IdentityModels
{
    using Microsoft.Build.Framework;

    public class Galery
    {
        public int Id { get; set; }

        [Required]
        public string ImageTitle { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
