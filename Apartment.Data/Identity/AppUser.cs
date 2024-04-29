﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Data.Identity
{
    internal class AppUser : IdentityUser<int>
    {
        public AppUser() : base() 
        {
        
        }
        public AppUser(string userName) : base(userName)
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
