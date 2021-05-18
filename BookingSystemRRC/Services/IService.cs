using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Services
{
    interface IService<T>
    {
        Task<IEnumerable<T>> GetObjectsAsync();
        Task AddObjectAsync(T obj);
        Task DeleteObjectAsync(T obj);
        Task UpdateObjectAsync(T obj);
        Task<T> GetObjectByIdAsync(int id); 
    
    
    }
}
