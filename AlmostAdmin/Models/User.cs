﻿using AlmostAdmin.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostAdmin.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {
            UserProjects = new List<UserProject>();
        }

        public AdminLevels AdminLevel { get; set; }

        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}
