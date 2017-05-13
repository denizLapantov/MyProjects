namespace FClubBarcelona.Models.IdentityModels
{
    using Microsoft.Build.Framework;

    public class MessageFromUser
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public ApplicationUser Sender { get; set; }
    }
}
