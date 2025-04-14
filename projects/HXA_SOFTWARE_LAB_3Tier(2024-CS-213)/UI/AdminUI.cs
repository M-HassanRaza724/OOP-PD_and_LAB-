﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXA_SOFTWARE_LAB.UI
{
    public static class AdminUI
    {
        public static int MainAdminMenu(string username)
        {
            Console.WriteLine($"\tHello {username}");
            Console.WriteLine("\t\t\tMENU");
            //Console.WriteLine("\t1. Admin Dashboard");
            Console.WriteLine("\t1. Order Management");
            Console.WriteLine("\t2. Manage Services");
            Console.WriteLine("\t3. Manage Sales Analytics");
            Console.WriteLine("\t4. Add Recent Top Projects");
            //Console.WriteLine("\t6. Client Reviews.");
            Console.WriteLine("\t5. Add New Admin Profile.");
            Console.WriteLine("\t6. Delete Admin Profile.");
            Console.WriteLine("\t7. Add New Customer Profile.");
            Console.WriteLine("\t8. Delete Customer Profile.");
            Console.WriteLine("\t9. SignOut.");
            Console.Write("\tEnter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
