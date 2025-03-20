using Microsoft.AspNetCore.Mvc;
using Peach_Clone.Data;
using Peach_Clone.Models;
using System.Linq;

namespace Peach_Clone.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ View-Based Endpoint (MVC)
        [HttpGet("FindEmployee")]
        public IActionResult FindEmployee(int? employeeNumber)
        {
            if (employeeNumber == null)
            {
                return View();
            }

            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);

            if (employee == null)
            {
                ViewBag.Message = "Employee not found!";
                return View();
            }

            ViewBag.Employee = employee;
            return View();
        }

        // ✅ JSON API Endpoint (Returns JSON)
        [HttpGet("{employeeNumber}")] // Route: Employee/101
        public IActionResult GetEmployee(int employeeNumber)
        {
            if (employeeNumber == 0)
            {
                return NotFound(new { message = "Invalid employee number!" });
            }

            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);

            if (employee == null)
            {
                return NotFound(new { message = "Employee not found!" });
            }

            return Ok(employee); // Returns JSON response
        }

        // ✅ Returns Partial Views for Section Loading
        [HttpGet]
        [Route("LoadSection")]
        public IActionResult LoadSection(string section, int employeeNumber)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber);
            if (employee == null) return NotFound();

            return section switch
            {
                "Overview" => PartialView("_Overview", employee),
                "AdditionalDetails" => PartialView("_AdditionalDetails", employee),
                "FamilyLeave" => PartialView("_FamilyLeave", employee),
                "ColleagueStatus" => PartialView("_ColleagueStatus", employee),
                "ForSuperUser" => PartialView("_ForSuperUser", employee),
                "Exception" => PartialView("_Exception", employee),
                _ => NotFound()
            };
        }
    }
}
