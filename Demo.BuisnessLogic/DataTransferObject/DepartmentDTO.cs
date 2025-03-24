using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuisnessLogic.DataTransferObject
{
    public class DepartmentDTO
    {
        public int DeptID { get; set; }
        public string DepartmentName { get; set; } 
        public string DepartmentCode { get; set; } = string.Empty;
        public string DepartmentDescription { get; set; } = string.Empty;
        public DateOnly DateOfCreation { get; set; }

    }
}
