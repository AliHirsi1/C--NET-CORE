using EmployeeManagement.Modal.Enum;
using EmployeeManagement.Modal.Modals;
using System.Collections.Generic;


namespace EmployeeManagement.Modal.Interface
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        List<Employee> GetAllEmployees();

        void AddNewEmployee(Employee emp);

        Department getEnum(int position);

        void EditEmployee(int id, string name, string email, Department department);

    }
}
