using Microsoft.EntityFrameworkCore;
using MyCleanAPI.Application.Interfaces;
using MyCleanAPI.Domain.Entities;
using MyCleanAPI.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCleanAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.ToListAsync();

        public async Task<User> GetByIdAsync(int id) => await _context.Users.FindAsync(id);

        public async Task AddAsync(User user) => await _context.Users.AddAsync(user);

        public void Update(User user) => _context.Users.Update(user);

        public void Delete(User user) => _context.Users.Remove(user);
    }
}
