using System.Collections.Generic;
using AspNetCore2Do.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCore2Do.Models
{
    public class ManageUsersViewModel
    {
        // Help Items stop complaining about null
        public ManageUsersViewModel()
        {
            Administrators = Array.Empty<IdentityUser>();
            Everyone = Array.Empty<IdentityUser>();
        }

        public IdentityUser[] Administrators { get; set; }
        public IdentityUser[] Everyone { get; set;}
    }
}