using Microsoft.EntityFrameworkCore;
using PenaltyCalculation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PenaltyCalculation.DataAccess.Concrete
{
    public class EfGenericDal<TEntity> : IGenericDal<TEntity>
       where TEntity : class, new()
    {
        private readonly AppDbContext context;
        private readonly DbSet<TEntity> _dbSet;

        public EfGenericDal(AppDbContext context)
        {
            this.context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _dbSet.ToList()
                : _dbSet.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
