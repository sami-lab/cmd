﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBuilder.ViewModel.Account
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认新密码")]
        [Compare("NewPassword", ErrorMessage =
            "新密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }
}
