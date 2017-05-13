﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FClubBarcelona.Models.IdentityModels;

namespace FClubBarcelona.Models.BindigModels.Players
{
    public class PlayersBm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Nationality { get; set; }

    }
}
