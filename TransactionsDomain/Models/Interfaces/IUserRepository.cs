using System.Threading.Tasks;

namespace TransactionsDomain.Models.Interfaces
{
    public interface IUserRepository
    {
        Task<int> InsertUser(User user);
        Task<User> GetUser(int Id);
        Task<int> DeleteUser(int Id);
        Task<User> UpdateUser(User user);
    }
}
