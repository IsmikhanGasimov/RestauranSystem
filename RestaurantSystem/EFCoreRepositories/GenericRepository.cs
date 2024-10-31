using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Contexts;
using RestaurantSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.EFCoreRepositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {

        private readonly RestaurantContext _context;


        public DbSet<T> Table { get; set; }
        public GenericRepository()
        {
            _context = new RestaurantContext();
            Table = _context.Set<T>();

        }

        public async Task Add(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }
    }
}
