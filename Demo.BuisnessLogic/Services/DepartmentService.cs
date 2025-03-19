using Demo.BuisnessLogic.DataTransferObject;
using Demo.BuisnessLogic.Factories;
using Demo.DataAccess.Models.DepartmentModels;
using Demo.DataAccess.Repositories.DepartmentRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuisnessLogic.Services
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        //private readonly IDepartmentRepository _departmentRepository = departmentRepository;
        //public DepartmentService(IDepartmentRepository departmentRepository) // 1. injection  CLR Inject Object
        //{
        //}
        // getAll Deparments

        public IEnumerable<DepartmentDTO> GetAllDepartments()
        {
            var department = _departmentRepository.GetAll();
            // Mapping Department to DepartmentDTO
            /// Manual Mapping
            ///var departmentsToReturn = department.Select(D => new DepartmentDTO()
            ///{
            ///    DeptID = D.Id,
            ///    DepartmentName = D.Name,
            ///    DepartmentCode = D.Code,
            ///    DepartmentDescription = D.Description,
            ///    DateOfCreation = DateOnly.FromDateTime((DateTime)D.CreatedOn)
            ///});
            ///return departmentsToReturn;
            ///
            // Extension Method Mapping
            return department.Select(D => D.ToDepartmentDTO());

        }
        // get Department By Id 
        public DepartmentDetailsDTO? GetDeparttmentByID(int id)
        {
            // Manual Mapping
            // Constructor Mapping 
            // Extension Method Mapping
            var department = _departmentRepository.GetById(id);
            //if (department is null) return null;
            //else
            //{
            //    var departmentDetails = new DepartmentDetailsDTO()
            //    {
            //        Id = department.Id,
            //        Name = department.Name,
            //        CreatedOn = DateOnly.FromDateTime((DateTime)department.CreatedOn)

            //    };
            //    return departmentDetails;
            /// Constructer Mapping
            ///return department is null ? null : new DepartmentDetailsDTO(department);
            ///
            /// Extension Method Mapping
            return department is null ? null : department.ToDepartmentDetailsDTO();

        }

        // Create New Department 
        public int AddDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            //_departmentRepository.Add(addDepartmentDTO)
            // convert AddDepartmentDTO to Department
            var department = addDepartmentDTO.ToEntity();
            return _departmentRepository.Add(department);
        }

        // Updated Department 
        public int UpdateDepartment(UpdatedDepartmentDTO updateDepartmentDTO)
        {
            // Convert UpdateDepartmentDTO to Department
            var department = updateDepartmentDTO.ToEntity();
            return _departmentRepository.Update(department);
        }
        // Delete Department 
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null) return false;
            else
            {
                int result = _departmentRepository.Remove(department);
                return result > 0 ? true : false;
            }
        }

    }
}
