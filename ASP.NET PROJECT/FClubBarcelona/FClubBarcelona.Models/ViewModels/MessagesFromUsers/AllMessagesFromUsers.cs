namespace FClubBarcelona.Models.ViewModels.MessagesFromUsers
{
    using System.ComponentModel;
    using IdentityModels;
    using Microsoft.Build.Framework;

    public class AllMessagesFromUsers
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Message From")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Email From")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Message")]
        public string Message { get; set; }

        [DisplayName("Logged as")]
        public ApplicationUser Sender { get; set; }
    }
}
