﻿
using Microsoft.AspNetCore.Identity;

namespace PMFI.Seguranca.Context
{
    //public class ApplicationUser : IdentityUser<string>
    public class ApplicationUser : IdentityUser
    {
       
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
