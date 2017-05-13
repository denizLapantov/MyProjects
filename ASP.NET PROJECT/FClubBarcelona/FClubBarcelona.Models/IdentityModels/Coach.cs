namespace FClubBarcelona.Models.IdentityModels
{
    using Microsoft.Build.Framework;

    public class Coach
    {
        public int Id { get; set; }

        [Required]
        public string FirstName  { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string CoachYears  { get; set; }
    }
}
