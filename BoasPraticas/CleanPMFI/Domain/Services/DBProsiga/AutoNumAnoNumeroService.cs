﻿using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class AutoNumAnoNumeroService : ServiceBase<AutoNumAnoNumero>, IAutoNumAnoNumeroService
    {
        private readonly IAutoNumAnoNumeroRepository _Repository;

        public AutoNumAnoNumeroService(IAutoNumAnoNumeroRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public async  Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno, string AutoTipo)
        {
            return await _Repository.GetMaxAutoNumAnoNumero(AutoAno, AutoTipo);
            //throw new NotImplementedException();
        }
        /*  public AutoNumAnoNumeroService(IRepositoryBase<AutoNumAnoNumero> _repository) : base(_repository)
 {
 }*/
    }
}
