using EmployeeManagement.Modal.Enum;
using EmployeeManagement.Modal.Interface;
using EmployeeManagement.Modal.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.Data.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){
                    Id = 1,
                    EmployeeName = "Mary",
                    Department = Department.HR,
                    Email = "mary@gmail.com",
                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar1"
                },
                new Employee(){
                    Id = 2,
                    EmployeeName = "John",
                    Department = Department.IT,
                    Email = "john@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar2"
                },
                new Employee(){
                    Id = 3,
                    EmployeeName = "Sam",
                    Department = Department.Finance,
                    Email = "sam@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar3"
                },
                new Employee(){
                    Id = 4,
                    EmployeeName = "Fred",
                    Department = Department.IT,
                    Email = "fred@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar4"
                },
                new Employee(){
                    Id = 5,
                    EmployeeName = "Aj",
                    Department = Department.IT,
                    Email = "aj@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar5"
                },
                new Employee(){
                    Id = 6,
                    EmployeeName = "Hanad",
                    Department = Department.Finance,
                    Email = "hanad@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar6"
                },
                new Employee(){
                    Id = 7,
                    EmployeeName = "Maryan",
                    Department = Department.Payroll,
                    Email = "mary@gmail.com",
                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar7"
                },
                new Employee(){
                    Id = 8,
                    EmployeeName = "James",
                    Department = Department.IT,
                    Email = "james@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar8"
                },
                new Employee(){
                    Id = 9,
                    EmployeeName = "Patrick",
                    Department = Department.IT,
                    Email = "patrick@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar9"
                },
                new Employee(){
                    Id = 10,
                    EmployeeName = "Corey",
                    Department = Department.HR,
                    Email = "corey@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar10"
                },
                new Employee(){
                    Id = 11,
                    EmployeeName = "Ian",
                    Department = Department.IT,
                    Email = "ian@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar11"
                },
                new Employee(){
                    Id = 12,
                    EmployeeName = "Jason",
                    Department = Department.Finance,
                    Email = "jason@gmail.com",

                    EmpImageLocation = @"C:\Users\Ali\Source\Repos\employeemanagement\EmployeeManagement\wwwroot\images\avatar12"
                }
            };
        }
        public void AddNewEmployee(Employee emp)
        {
            _employeeList.Add(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeList.ToList();

        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.Where(em => em.Id == id).FirstOrDefault();
        }

        public Department getEnum(int position)
        {
            var names = (Department[])Enum.GetValues(typeof(Department));
            return (Department)names.GetValue(position);
        }

        public void EditEmployee(int id, string name, string email, Department department)
        {
            var result = GetEmployee(id);
            result.EmployeeName = name;
            result.Department = department;
            result.Email = email;
        }

        
    }
}
