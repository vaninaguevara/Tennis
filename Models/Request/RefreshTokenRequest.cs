﻿using System.ComponentModel.DataAnnotations;

namespace EscuelaDotNetAbril2024.API.Models.Request
{
    public class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
