using Demo.BuisnessLogic.Services;
using Demo.DataAccess.Repositories.DepartmentRepositorys;
using Microsoft.AspNetCore.Mvc;

namespace DemoPLL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService) : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
