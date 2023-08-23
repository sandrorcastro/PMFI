using PMFI.Application.Interfaces.Base;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFI.Application.Interfaces
{
    public interface IUfAppService : IAppServiceBase<Uf,UfViewModel>
    {
    }
}
