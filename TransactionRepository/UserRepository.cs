using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TransactionsDomain.Models;
using TransactionsDomain.Models.Interfaces;

namespace TransactionRepository
{
    public class UserRepository : IUserRepository
    {
        public Task<int> DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
