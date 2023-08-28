using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMFI.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFI.Infra.TESTEARDELIS
{
    public class CidadeRepositoryBase<Cidade> : RepositoryBase<Cidade>  where Cidade : class
    {
        private readonly  ApplicationDbContext _dbContext;
        public CidadeRepositoryBase(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
