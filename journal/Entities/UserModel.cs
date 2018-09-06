﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace journal.Entities
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; }
    }
}