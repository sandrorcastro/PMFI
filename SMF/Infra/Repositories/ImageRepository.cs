using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public ImageRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public ImageRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
