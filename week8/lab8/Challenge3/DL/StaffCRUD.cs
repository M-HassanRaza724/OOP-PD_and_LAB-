using Challenge3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.DL
{
    class StaffCRUD
    {
        public static List<Staff> staffs = new List<Staff>();

        public static void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }
        public static void DeleteStaff(string name)
        {
            foreach (Staff staff in staffs)
            {
                if (staff.GetName() == name)
                {
                    staffs.Remove(staff);
                    break;
                }
            }
        }
        public static Staff GetStaff(string name)
        {
            foreach (Staff p in staffs)
            {
                if (p.GetName() == name)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Staff> GetAllStaffs()
        {
            return staffs;
        }
    }
}
