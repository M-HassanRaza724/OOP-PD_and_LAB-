﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Xml.Linq;
using HXA_SOFTWARE_LAB.DL;

namespace HXA_SOFTWARE_LAB.BL
{
    public class MUser
    {
        public string Email { get; set; }
        public string Username { get ; set ;}
        public string Password { get ; set ;}
        public string UserRole { get ; set ;}

        public MUser(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            UserRole = "customer";
        }

        public MUser() { }

    }
}
