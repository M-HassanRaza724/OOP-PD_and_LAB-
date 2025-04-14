using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.DL
{
    class StudentAccountCRUD
    {
        public static List<StudentAccount> studentAccounts = new List<StudentAccount>();
        public static void AddStudentAccount(StudentAccount studentAccount)
        {
            studentAccounts.Add(studentAccount);
        }
        public static void DeleteStudentAccount(int studentAccountNo)
        {
            foreach (StudentAccount studentAccount in studentAccounts)
            {
                if (studentAccount.GetAccountNo() == studentAccountNo)
                {
                    studentAccounts.Remove(studentAccount);
                    break;
                }
            }
        }
        public static StudentAccount GetStudentAccount(int studentAccountNo)
        {
            foreach (StudentAccount studentAccount in studentAccounts)
            {
                if (studentAccount.GetAccountNo() == studentAccountNo)
                {
                    return studentAccount;
                }
            }
            return null;
        }
        public static List<StudentAccount> GetAllStudentAccounts()
        {
            return studentAccounts;
        }
    }
}
