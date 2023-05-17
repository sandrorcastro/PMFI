

using Domain.Interfaces.Base;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Infra.Repositories
{
   public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
   // public class RepositoryBase<TEntity> :  IRepositoryBase<TEntity> where TEntity : class
    {
        //protected ProjetoModeloContext db = new ProjetoModeloContext();
        //private IDbContextFactory<ContextoAplicacao> dbF;
        //protected ContextoAplicacao contexto;
        public ContextoAplicacao contexto;

        //public RepositoryBase(IDbContextFactory<ContextoAplicacao> dbf)
        public RepositoryBase(ContextoAplicacao contexto)
        {
          //  this.dbF = dbf;
           // using (var db = dbF.CreateDbContext())
            //{
                this.contexto = contexto;

            //}
        }
        public IQueryable<TEntity> GetIQueryable()
        {
            try
            {
                return contexto.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DbSet<TEntity> GetDbSet()
        {
            try
            {
                return contexto.Set<TEntity>();
                //return contexto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<TEntity> GetIQueryable(Func<TEntity, bool> predicate)
        {
            return contexto.Set<TEntity>().Where(predicate).AsQueryable();
        }
        public IQueryable<TEntity> GetIQueryable(params object[] key)
        {
            return (IQueryable<TEntity>)contexto.Set<TEntity>().Find(key);
        }

        public void Add(TEntity obj)
        {
            //using(var contexto = db.CreateDbContext())
            //{

                contexto.Set<TEntity>().Add(obj);
                contexto.SaveChanges();
            //}
        }

        public TEntity GetById(int id)
        {
            //using (var contexto = db.CreateDbContext())
            //{

            return contexto.Set<TEntity>().Find(id);
            //}
        }
        
        public TEntity GetById(long id)
        {
            //using (var contexto = db.CreateDbContext())
            //{

                return contexto.Set<TEntity>().Find(id);
            //}
        }

        public IEnumerable<TEntity> GetAll()
        {
            //using (var contexto = db.CreateDbContext())
            //{

                return contexto.Set<TEntity>().ToList();
            //}
        }

        public void Update(TEntity obj)
        {
            //using (var contexto = db.CreateDbContext())
            //{

                contexto.Entry(obj).State = EntityState.Modified;
                contexto.SaveChanges();
            //}
        }

        public void Remove(TEntity obj)
        {
            //using (var contexto = db.CreateDbContext())
            //{

                contexto.Set<TEntity>().Remove(obj);
                contexto.SaveChanges();
            //}
        }

       public void Dispose()
        {
            try
            {
              //  using (var contexto = db.CreateDbContext())
                //{

                    contexto.Dispose();
                //}
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
  
///////////////////
        public IQueryable<TEntity> GetTodos()
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                    return contexto.Set<TEntity>();
                //}

            } catch(Exception ex)
            {
                throw ex;
            }

        }

        public IQueryable<TEntity> GetById()
        {
            return contexto.Set<TEntity>();
        }
        public IQueryable<TEntity> GetById(Func<TEntity, bool> predicate)
        {
            return contexto.Set<TEntity>().Where(predicate).AsQueryable();
        }
        public IQueryable<TEntity> GetById(params object[] key)
        {
            return (IQueryable<TEntity>)contexto.Set<TEntity>().Find(key);
        }





        
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                    return GetAll().Where(predicate).AsQueryable();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TEntity GetRelacoes(Func<TEntity, bool> predicate)
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                return contexto.Set<TEntity>().Find(predicate);//   GetAll().Where(predicate);
                //return contexto.Set<TEntity>();//   GetAll().Where(predicate);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public TEntity Find(Func<TEntity, bool> predicate)
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                return contexto.Set<TEntity>().Find(predicate);//   GetAll().Where(predicate);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Find(params object[] key)
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
               // {

                    return contexto.Set<TEntity>().Find(key);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void SalvarTodos()
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                    contexto.SaveChanges();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Remove(Func<TEntity, bool> predicate)
        {
            try
            {
                //using (var contexto = db.CreateDbContext())
                //{

                    contexto.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => contexto.Set<TEntity>().Remove(del));
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
