﻿using NiceWord.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceWord.UI.Areas.Admin.Models.DTO
{
    public class AppUserDTO:BaseDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string ImagePath { get; set; }
    }
}