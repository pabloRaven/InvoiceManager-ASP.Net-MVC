﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceMenager.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
