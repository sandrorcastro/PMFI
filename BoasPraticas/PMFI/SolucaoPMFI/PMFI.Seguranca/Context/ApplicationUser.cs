
using Microsoft.AspNetCore.Identity;
using PMFI.Seguranca.Models;

namespace PMFI.Seguranca.Context
{
    //public class ApplicationUser : IdentityUser<string>
    public class ApplicationUser : IdentityUser
    {
      //  public Guid CompanyId { get; set; }
      //  public Company Company { get; set; }
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
