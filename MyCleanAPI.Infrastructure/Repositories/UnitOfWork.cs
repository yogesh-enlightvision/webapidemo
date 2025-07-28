using MyCleanAPI.Application.Interfaces;
using MyCleanAPI.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace MyCleanAPI.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUserRepository Users { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();
    }
}
