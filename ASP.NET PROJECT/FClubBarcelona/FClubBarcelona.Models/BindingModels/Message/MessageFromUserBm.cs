namespace FClubBarcelona.Models.BindingModels.Message
{
    using Microsoft.Build.Framework;

    public class MessageFromUserBm
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
