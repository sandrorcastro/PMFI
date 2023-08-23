using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace PMFI.Domain.Interfaces.Base
{
    public interface ISpecificationBase<TEntity> where TEntity : class
    {
        public Expression<Func<TEntity, bool>> Criteria { get; }
        public List<Expression<Func<TEntity, object>>> Includes { get; }
        public List<string> IncludeStrings { get; }
    }
}
