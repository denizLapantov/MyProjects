namespace FClubBarcelona.Models.ViewModels.Home
{
    using System;
    using System.ComponentModel;
    using Microsoft.Build.Framework;

    public class DetailsPlayersVm
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        [Required]
        [DisplayName("Video")]
        public string VideoUrl { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Nationality { get; set; }
    }
}
