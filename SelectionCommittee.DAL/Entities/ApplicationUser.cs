﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace SelectionCommittee.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public Enrollee Enrollee { get; set; }
    }
}
