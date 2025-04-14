using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Xml.Linq;

namespace ProductManagement
{
    public class MUser
    {
        public string Email;
        public string Username;
        public string Password;
        public int UserRole;

        public MUser() { }

        public MUser(string username, string email, string password, int userRole = 1)
        {
            Username = username;
            Email = email;
            Password = password;
            UserRole = userRole;
        }
        public MUser(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getUsername()
        {
            return Username;
        }
        public string getPassword()
        {
            return Password;
        }
        public int getUserRole()
        {
            return UserRole;
        }


        public static bool AuthenticateUser(MUser user)  // need in login
        {
            MUser userOriginal = MUserCRUD.IsUserPresent(user.Email);
            if(userOriginal.Email != null)
            {
                if (user.Password == userOriginal.Password);
                {
                    user = userOriginal;
                    return true;
                }
            }
            return false;
        }
        public bool AuthenticateUser(string password)
        {
            if (password == Password)
                return true;
            return false;
        }
    }
}
