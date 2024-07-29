using Microsoft.AspNetCore.Mvc;
using EmployeeManagement_web_app.Data;

[Route("api/[controller]")]
[ApiController]
public class LoginController : Controller
{
    private readonly ApplicationDbContext _context;
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        try{
                var employee = _context.Employees.FirstOrDefault(u => u.Email == username && u.Password == password);
                
                if (employee == null)
                {
                    return NotFound($"wrong username or password"); // Return 404 Not Found if user with the given ID is not found
                }

                return RedirectToAction("GetEmployeeById","Employee",new { id = employee.Id });
            } 
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
    }
}