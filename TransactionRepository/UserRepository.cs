using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TransactionsDomain.Models;
using TransactionsDomain.Models.Interfaces;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace TransactionRepository
{
    public class UserRepository : IUserRepository
    {
        private IApplicationConfiguration _applicationConfiguration;

        public UserRepository(IApplicationConfiguration applicationConfiguration)
        {
            _applicationConfiguration = applicationConfiguration;
        }
        public async Task<int> InsertUser(User user)
        {
            using IDbConnection connection = new SqlConnection(_applicationConfiguration.ConnectionString);
            var p = new DynamicParameters();
            p.Add("@Name", user.Name);
            p.Add("@Email", user.Email);

            var output = await connection.ExecuteScalarAsync<int>("sp_Insert_User", p, commandType: CommandType.StoredProcedure);

            return output;

        }
        public Task<int> DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int Id)
        {
            throw new NotImplementedException();
        }


        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
