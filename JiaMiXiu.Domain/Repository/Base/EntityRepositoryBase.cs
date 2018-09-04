using MyMvc.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JiaMiXiu.Domain.Repository
{
    public class EntityRepositoryBase<F> where F : class, new()
    {
        private DbContext Db = EF_Factory.GetDb();
        public DbSet<F> GetDbSet()
        {
            return Db.Set<F>();
        }
        public F QueryFirst(Expression<Func<F, bool>> predicate)
        {
            F model = null;
            try
            {
                model = Db.Set<F>().AsNoTracking().FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                NLogHelper.WriteError(ex.Message);
            }
            return model;
        }
        public List<F> QueryList(Expression<Func<F, bool>> predicate)
        {
            return Db.Set<F>().AsNoTracking().Where(predicate).AsEnumerable().ToList();
        }
        public List<F> SqlList(string sql, List<SqlParameter> parameters)
        {
            return Db.Database.SqlQuery<F>(sql, parameters.ToArray()).ToList();
        }
        public bool Delete(F f)
        {
            Db.Entry<F>(f).State = EntityState.Deleted;
            return Db.SaveChanges() > 0;
        }
        public bool Update(F f)
        {
            var model = Db.Set<F>().Attach(f);
            Db.Entry<F>(f).State = EntityState.Modified;
            return Db.SaveChanges() > 0;
        }
        public bool Delete(Expression<Func<F, bool>> predicate)
        {
            var model = QueryFirst(predicate);
            Db.Entry<F>(model).State = EntityState.Deleted;
            return Db.SaveChanges() > 0;
        }
        public bool Add(F f)
        {
            Db.Entry<F>(f).State = EntityState.Added;
            return Db.SaveChanges() > 0;
        }
    }
}
