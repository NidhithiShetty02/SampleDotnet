﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGoatCore.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Display(Name = "Old Password")]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Text)]
        public string OldPassword { get; set; }

        [Display(Name = "New Password")]
        [Required(ErrorMessage = "New Password is required.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm New Password")]
        [Required(ErrorMessage = "You must confirm your new password.")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "The password and confirmation password do not match")]
        public string ConfirmedNewPassword { get; set; }
    }
}
