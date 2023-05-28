using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace Infra.EntityConfig
namespace Infra.Context
{
    public class ApplicationUser : IdentityUser<long>
    {

        [PersonalData]
        public long ServidorId { get; set; }
        [PersonalData]
        public virtual Servidor Servidor { get; set; }
      // public long ServidorId { get; set; }
//       public virtual Servidor? Servidor { get; set; }

    }
}
