using BikeStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreApp.Services
{
    public class LoginService
    {
        public List<User> userList { get; set; }

        public LoginService() {
        }

        public List<User> GetUserList()
        {
            userList = new List<User>();
            for (int i = 0; i < 20; i++)
            {
                var user = new User() 
                {
                    UserId = i,
                    Name = $"User Name {i.ToString()}",
                    Surname= $"User Surname {i.ToString()}",
                    Email= $"email{i}@gmail.com"                    
                };
                userList.Add(user);
            }
            return userList;
        }
    }
}
