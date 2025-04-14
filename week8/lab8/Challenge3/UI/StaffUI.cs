using Challenge3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.UI
{
    class StaffUI
    {
        public Staff InputStaff()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter School: ");
            string school = Console.ReadLine();
            Console.Write("Enter Pay: ");
            double pay = double.Parse(Console.ReadLine());

            return new Staff(name, address, school, pay);
        }
        public void PrintStaff(Staff staff)
        {
            Console.WriteLine(staff.ToString());
        }
        public void PrintStaffList(List<Staff> staffList)
        {
            foreach (var staff in staffList)
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
}
