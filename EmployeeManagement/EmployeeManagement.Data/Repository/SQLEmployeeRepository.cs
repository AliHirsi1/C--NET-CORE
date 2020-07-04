using EmployeeManagement.Data.Context;
using EmployeeManagement.Modal.Enum;
using EmployeeManagement.Modal.Interface;
using EmployeeManagement.Modal.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.Data.Repository
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void AddNewEmployee(Employee emp)
        {
            _context.Employee.Add(emp);
            _context.SaveChanges();

        }

        public void EditEmployee(int id, string name, string email, Department department)
        {
            Employee employee = new Employee();
            employee = GetEmployee(id);
            employee.EmployeeName = name;
            employee.Department = department;
            employee.Email = email;
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employee.Where(e => e.Id == id).FirstOrDefault();
        }

        public Department getEnum(int position)
        {
            var names = (Department[])Enum.GetValues(typeof(Department));
            return (Department)names.GetValue(position); ;
        }

        
    }
}
