namespace Domain.Interfaces.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        TEntity GetById(long id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

        ///////////////////
        IQueryable<TEntity> GetTodos();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        public TEntity GetRelacoes(Func<TEntity, bool> predicate);
        public TEntity Find(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void SalvarTodos();
        void Remove(Func<TEntity, bool> predicate);
        

    }
}
