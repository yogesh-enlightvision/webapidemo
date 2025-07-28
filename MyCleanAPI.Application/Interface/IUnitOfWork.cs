using System.Threading.Tasks;

namespace MyCleanAPI.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task<int> CompleteAsync();
    }
}