﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KlimaServisProje.Models.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {

        }
        public ApplicationRole(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        [StringLength(100)]
        public string Description { get; set; }
    }
}
