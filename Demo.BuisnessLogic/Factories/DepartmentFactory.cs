using Demo.BuisnessLogic.DataTransferObject;
using Demo.DataAccess.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuisnessLogic.Factories
{
    public static class DepartmentFactory
    {
        // extencsion Methode 
        // Convert Department => DepartmentDTO
        public static DepartmentDTO ToDepartmentDTO(this Department D)
        {
            return new DepartmentDTO()
            {
                DeptID = D.Id,
                DepartmentName = D.Name,
                DepartmentCode = D.Code,
                DepartmentDescription = D.Description,
                DateOfCreation = DateOnly.FromDateTime((DateTime)D.CreatedOn)
            };
        }
        // Convert Department => DepartmentDetailsDTO
        public static DepartmentDetailsDTO ToDepartmentDetailsDTO(this Department D)
        {
            return new DepartmentDetailsDTO()
            {
                Id = D.Id,
                Name = D.Name,
                CreatedOn = DateOnly.FromDateTime((DateTime)D.CreatedOn)
            };
        }
        // Convert  AddDepartmentDTO => Department
        public static Department ToEntity(this AddDepartmentDTO addDepartmentDTO)
        {
            return new Department()
            {
                Name = addDepartmentDTO.Name,
                Code = addDepartmentDTO.Code,
                Description = addDepartmentDTO.Description,
                CreatedOn = addDepartmentDTO.DateOfCreation.ToDateTime(new TimeOnly()),

            };

        }
        // Convert UpdateDepartmentDTO to Department
        public static Department ToEntity (this UpdatedDepartmentDTO departmentDTO)
        {
            return new Department()
            {
                Id = departmentDTO.Id,
                Name = departmentDTO.Name,
                Code = departmentDTO.Code,
                Description = departmentDTO.Description,
                CreatedOn = departmentDTO.DateOfCreation.ToDateTime(new TimeOnly())

            };
        }
    }
}
