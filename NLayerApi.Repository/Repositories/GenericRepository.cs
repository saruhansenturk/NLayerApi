﻿using Microsoft.EntityFrameworkCore;
using NLayerApi.Core.Repositories;
using NLayerApi.Repository.Context;
using System.Linq.Expressions;

namespace NLayerApi.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;   //generix repoda constructor da dbSete parametre vermemeliyiz.


        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable(); //kayitlar memory'e alinmasin sadece datayi gostersin. asnotracking
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id) ?? throw new InvalidOperationException();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
