using JiaMiXiu.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace JiaMiXiu.Domain.IRepository
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        bool Add(T t);
        bool Update(T t);
        bool Delete(T t);
        DbSet<T> GetDbSet();
        Database GetDatabase();
        DbContextTransaction BeginTransaction();
        T QueryFirst(Expression<Func<T, bool>> predicate);
        List<T> QueryList(Expression<Func<T, bool>> predicate);
        List<T> SqlList(string sql, List<SqlParameter> parameters);
        bool ExecSql(string sql, List<SqlParameter> parameters);
        bool Delete(Expression<Func<T, bool>> predicate);
        EntityRepositoryBase<F> GetEntityRepository<F>() where F : class, new();

    }
}
