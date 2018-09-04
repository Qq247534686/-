using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using MyMvc.Core;

namespace JiaMiXiu.Domain.Repository
{
    public class RepositoryBase<T> where T : class, new()
    {
        private DbContext Db = EF_Factory.GetDb();


        public EntityRepositoryBase<F> GetEntityRepository<F>() where F : class, new()
        {
            return new EntityRepositoryBase<F>();
        }
        public DbSet<T> GetDbSet()
        {
            return Db.Set<T>();
        }
      
        public Database GetDatabase()
        {

            return EF_Factory.GetDb().Database;
        }
        public T QueryFirst(Expression<Func<T, bool>> predicate)
        {
            T model = null;
            try
            {
                model = Db.Set<T>().AsNoTracking().FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                NLogHelper.WriteError(ex.Message);
            }
            return model;
        }
        public List<T> QueryList(Expression<Func<T, bool>> predicate)
        {
            return Db.Set<T>().AsNoTracking().Where(predicate).AsEnumerable().ToList();
        }
        public List<T> SqlList(string sql, List<SqlParameter> parameters)
        {
            return GetDatabase().SqlQuery<T>(sql, parameters.ToArray()).ToList();
        }
        public bool ExecSql(string sql, List<SqlParameter> parameters)
        {
            return GetDatabase().ExecuteSqlCommand(sql, parameters.ToArray()) > 0;
        }
        public bool Update(T t)
        {
            var model = Db.Set<T>().Attach(t);
            Db.Entry<T>(t).State = EntityState.Modified;
            return Db.SaveChanges() > 0;
        }
        public bool Delete(T t)
        {
            Db.Entry<T>(t).State = EntityState.Deleted;
            return Db.SaveChanges() > 0;
        }
        public bool Delete(Expression<Func<T, bool>> predicate)
        {
            var model = QueryFirst(predicate);
            Db.Entry<T>(model).State = EntityState.Deleted;
            return Db.SaveChanges() > 0;
        }
        public bool Add(T t)
        {
            Db.Entry<T>(t).State = EntityState.Added;
            return Db.SaveChanges() > 0;
        }
        public DbContextTransaction BeginTransaction()
        {
            return GetDatabase().BeginTransaction();
        }
    }
}