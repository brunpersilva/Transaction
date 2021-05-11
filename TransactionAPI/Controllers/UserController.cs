using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionAPI.Models;
using TransactionsDomain.Models;
using TransactionsDomain.Models.Interfaces;

namespace TransactionAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("insert")]
        [HttpPost]
        public async Task<CreatedUser> InsertUser([FromBody] User user) =>
             new CreatedUser { Id = await _userRepository.InsertUser(user) };
 
    }
}
