using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystemRRC.Services
{
    public class DbGenericService<T> : IService<T> where T : class 
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new BookingDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }


        public async Task AddObjectAsync(T obj)
        {
            using (var context = new BookingDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }

        }


        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new BookingDbContext())
            {
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
            }
        }



        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new BookingDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }

        }

        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new BookingDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }
    }
}
