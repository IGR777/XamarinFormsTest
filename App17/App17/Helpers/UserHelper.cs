using App17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17.Helpers
{
    class UserHelper
    {
        private UserHelper()
        {
            Users = new List<User>();
        }

        static Lazy<UserHelper> _instance = new Lazy<UserHelper>(()=> new UserHelper());

        public static UserHelper Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<User> Users { get; set; }

        public void AddOrUpdate(User user)
        {
            var existedUser = Users.FirstOrDefault(item=>item.Name.Equals(user.Name));
            if (existedUser != null)
            {
                Users.Remove(existedUser);
            }
            Users.Add(user);
        }

    }
}
