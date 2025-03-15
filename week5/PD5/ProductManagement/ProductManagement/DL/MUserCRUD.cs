using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{

    public class MUserCRUD
    {
        static public List<MUser> users = new List<MUser>(); 
        static public void AddUser(MUser user)
        {
            string query = $"INSERT INTO Users VALUES ('{user.getUsername()}', '{user.getEmail()}', '{user.getPassword()}', '{user.getUserRole()}')";
            DatabaseHelper.Instance.Update(query);
        }

        static public void EditUser(MUser user)
        {
            string query = $"UPDATE Users SET Name = '{user.getUsername()}', CGPA = {user.getPassword()}  WHERE Email = '{user.getEmail()}'";
            DatabaseHelper.Instance.Update(query);
        }

        static public void DeleteUser(MUser user)
        {
            string query = $"DELETE FROM User WHERE Email = '{user.Email}'";
            DatabaseHelper.Instance.Update(query);
        }

        static public MUser IsUserPresent(string email)
        {
            string query = $"SELECT * FROM Users WHERE Email = '{email}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                return new MUser($"{reader["UserName"]}",$"{reader["Email"]}", $"{reader["Password"]}", int.Parse($"{reader["UserRole"]}"));
            }
            return new MUser();
        }
    }
}
