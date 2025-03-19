using Demo.BuisnessLogic.DataTransferObject;

namespace Demo.BuisnessLogic.Services
{
    public interface IDepartmentService
    {
        int AddDepartment(AddDepartmentDTO addDepartmentDTO);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDTO> GetAllDepartments();
        DepartmentDetailsDTO? GetDeparttmentByID(int id);
        int UpdateDepartment(UpdatedDepartmentDTO updateDepartmentDTO);
    }
}