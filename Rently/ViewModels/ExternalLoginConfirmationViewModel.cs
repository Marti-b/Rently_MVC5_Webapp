﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rently.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string Phone { get; set; }
    }
}