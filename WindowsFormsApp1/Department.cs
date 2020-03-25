using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Department
    {
        public static int DepartmentID { get; set; }
        public static string DepartmentTitle { get; set; }
        public Department(int departmentID, string departmentTitle)
        {
            DepartmentID = departmentID;
            DepartmentTitle = departmentTitle;
        }
    }
}
