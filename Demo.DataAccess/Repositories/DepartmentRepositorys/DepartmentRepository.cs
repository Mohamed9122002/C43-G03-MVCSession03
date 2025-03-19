using Demo.DataAccess.Data.Contexts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.DepartmentRepositorys
{
    // Primary Constructor .Net 8 c#12

    public class DepartmentRepository(ApplictionDbContext dbContext) : IDepartmentRepository
    {
        private readonly ApplictionDbContext _dbContext = dbContext;

        //ApplictionDbContext dbContext;
        //public DepartmentRepository(ApplictionDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        #region  Dependency Injection
        // does not use primary constructor
        //public DepartmentRepository(ApplictionDbContext dbContext) //1. injection  CLR Inject Object
        //{
        //    this._dbContext = dbContext;
        //}
        #endregion
        // GRUD Opeartions
        // Get All Departments
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {

            if (WithTracking)
                return _dbContext.Departments.ToList();
            else
                return _dbContext.Departments.AsNoTracking();
        }
        // Get Department by Id
        public Department? GetById(int id)
        {
            return this._dbContext.Departments.Find(id);
        }
        // Add Department
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }
        // Update Department
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
        // Delete Department
        public int Remove(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }
    }
}
