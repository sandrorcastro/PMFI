namespace Domain.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public void Add(TEntity obj);
        public TEntity GetById(int id);
        public TEntity GetById(long id);
        public IEnumerable<TEntity> GetAll();
        public void Update(TEntity obj);
        public void Remove(TEntity obj);
        public void Dispose();
        ///////////////////
        
        public IQueryable<TEntity> GetById();
        public IQueryable<TEntity> GetById(Func<TEntity, bool> predicate);
        public IQueryable<TEntity> GetById(params object[] key);

        public IQueryable<TEntity> GetTodos();
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        
        public TEntity GetRelacoes(Func<TEntity, bool> predicate);
        
        public TEntity Find(Func<TEntity, bool> predicate);
        public TEntity Find(params object[] key);
        
        public void SalvarTodos();
        public void Remove(Func<TEntity, bool> predicate);
    }
}
