﻿using System.ComponentModel.DataAnnotations;

namespace MFU.Models
{
    public class Credentials
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
