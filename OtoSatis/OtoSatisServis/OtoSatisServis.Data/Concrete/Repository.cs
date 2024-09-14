﻿using Microsoft.EntityFrameworkCore;
using OtoSatisServis.Data.Abstract;
using OtoSatisServis.Entities;
using System.Linq.Expressions;

namespace OtoSatisServis.Data.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet;
        public Repository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        
        public void Add(T entitiy)
        {
           _dbSet.Add(entitiy);
        }

        public async Task AddAsync(T entitiy)
        {
           await _dbSet.AddAsync(entitiy);
        }

        public void Delete(T entitiy)
        {
           _dbSet.Remove(entitiy);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
           return await _dbSet.FindAsync(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
           return _dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
           return _dbSet.Where(expression).ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
          return await  _dbSet.Where(expression).ToListAsync();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefaultAsync(expression);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entitiy)
        {
            _context.Update(entitiy);
        }
    }
}
