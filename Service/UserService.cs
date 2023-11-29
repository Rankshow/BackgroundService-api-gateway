using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackgroundService_api_gateway.Model;

namespace BackgroundService_api_gateway.Service
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Name = "Gabriel",
                    Email = "gabreiel@gmail.com"
                }
            };
        }
    }
}