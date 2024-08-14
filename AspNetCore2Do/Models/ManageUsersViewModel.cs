using System.Collections.Generic;
using AspNetCore2Do.Models;

namespace AspNetCore2Do.Models
{
    public class ManageUsersViewModel
    {
        public IdentityUser[] Administrators { get; set; }

        public IdentityUser[] Everyone { get; set;}
    }
}