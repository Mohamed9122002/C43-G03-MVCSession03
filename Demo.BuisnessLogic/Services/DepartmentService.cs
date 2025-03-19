using Demo.DataAccess.Repositories.DepartmentRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuisnessLogic.Services
{
    public class DepartmentService
    {
        public DepartmentService(IDepartmentRepository departmentRepository) // 1. injection  CLR Inject Object
        {
            

        }
    }
}
