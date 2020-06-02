﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.WebAPI.Models
{
    public class Role :IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
