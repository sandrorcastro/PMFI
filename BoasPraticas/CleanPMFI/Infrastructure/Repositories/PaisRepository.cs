using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Repositories
{
    public class PaisRepository : RepositoryBase<Pais>, IPaisRepository
    {
        public PaisRepository(ApplicationDbContext _contextFactory) : base(_contextFactory)
        {
        }
    }
}
