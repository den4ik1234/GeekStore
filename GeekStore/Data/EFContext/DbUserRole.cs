﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekStore.Data.EFContext
{
    public class DbUserRole:IdentityUserRole<string>
    {
        public virtual DbUser User { get; set; }
        public virtual DbRole Role { get; set; }
    }
}
