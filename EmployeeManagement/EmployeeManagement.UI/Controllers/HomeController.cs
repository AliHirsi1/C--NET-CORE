using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using EmployeeManagement.Modal.Interface;
using EmployeeManagement.Modal.Modals;
using EmployeeManagement.UI.ViewModal;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeManagement.UI
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [Route("")]
        [Route("Index")]
        [Route("~/")]
        [HttpGet]
        public ViewResult Index()
        {
            List<EmployeeVM> modal = new List<EmployeeVM>();
            var result = _employeeRepository.GetAllEmployees();

            result.ForEach(em =>
            {
                var emp = new EmployeeVM()
                {
                    EmployeeName = em.EmployeeName,
                    Email = em.Email,
                    Department = em.Department,
                    EmpImageLocation = em.EmpImageLocation

                };
                modal.Add(emp);
            });
            return View(modal);
        }

        [Route("EditEmployee")]
        [HttpPost]
        public ActionResult EditEmployee(int Id, string name, string email, string dept)
        {
            int position = Convert.ToInt32(dept);

            var department = _employeeRepository.getEnum(position);
            _employeeRepository.EditEmployee(Id, name, email, department);

            return RedirectToAction("Index");
        }

        [Route("AddEmployee")]
        [HttpPost]
        public ActionResult AddEmployee(string name, string email, string dept)
        {
            var employee = new Employee()
            {
                Id = _employeeRepository.GetAllEmployees().Max(i => i.Id) + 1,
                EmployeeName = name,
                Email = email,
                Department = _employeeRepository.getEnum(int.Parse(dept))

            };
            _employeeRepository.AddNewEmployee(employee);

            return RedirectToAction("Index");
        }
    }
}
