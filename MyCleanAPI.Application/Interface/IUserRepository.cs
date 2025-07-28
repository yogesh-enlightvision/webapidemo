using MyCleanAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCleanAPI.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        void Update(User user);
        void Delete(User user);
    }
}