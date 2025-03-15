using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class CustomerCRUD
    {
        static public List<Customer> customers = new List<Customer>();
        static public void AddCustomer(Customer customer)
        {
            string query = $"INSERT INTO Customers VALUES ('{customer.getCustomername()}', '{customer.getEmail()}')";
            DatabaseHelper.Instance.Update(query);
        }

        static public void EditCustomer(Customer customer)
        {
            string query = $"UPDATE Customers SET Name = '{customer.getCustomername()}', CGPA = {customer.getPassword()}  WHERE Email = '{customer.getEmail()}'";
            DatabaseHelper.Instance.Update(query);
        }

        static public void DeleteCustomer(Customer customer)
        {
            string query = $"DELETE FROM Customers WHERE Email = '{customer.Email}'";
            DatabaseHelper.Instance.Update(query);
        }

        static public Customer IsCustomerPresent(string email)
        {
            string query = $"SELECT * FROM Customers WHERE Email = '{email}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                return new Customer($"{reader["CustomerName"]}", $"{reader["Email"]}", $"{reader["Password"]}", int.Parse($"{reader["CustomerRole"]}"));
            }
            return new Customer();
        }
    }
}
