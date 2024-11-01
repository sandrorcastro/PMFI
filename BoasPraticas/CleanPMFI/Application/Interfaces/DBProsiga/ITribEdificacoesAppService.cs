﻿using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface ITribEdificacoesAppService : IAppServiceBase<TribEdificaco>
    {
        public Task<TribEdificaco> GetByInscricaoImobiliaria(string inscricao);
    }
}
