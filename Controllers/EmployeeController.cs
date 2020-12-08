using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeAPI.Services;
using EmployeeAPI.Controllers;
using EmployeeAPI;

namespace OcelotWebGW.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private ILogger _logger;
        private IEmployeeAPI _API;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeAPI api)
        {
            _logger = logger;
            _API = api;
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployee()
        {
            return _API.GetEmployees();
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            _API.AddEmployee(employee);
            return employee;
        }

        [HttpPut("{name}")]
        public ActionResult<Employee> UpdateEmployee(string name, Employee employee)
        {
            _API.UpdateEmployee(name, employee);
            return employee;
        }

        [HttpDelete("{name}")]
        public ActionResult<string> DeleteEmployee(string name)
        {
            _API.DeleteEmployee(name);
            return name;
        }
    }
}
