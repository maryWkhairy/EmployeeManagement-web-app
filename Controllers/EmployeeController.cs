using System;
using EmployeeManagement_web_app.Models;
using EmployeeManagement_web_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement_web_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try{
                var employee = _context.Employees.FirstOrDefault(u => u.Id == id);
                
                if (employee == null)
                {
                    return NotFound($"Employee with ID {id} not found"); // Return 404 Not Found if user with the given ID is not found
                }

                return View(employee);
            } 
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}