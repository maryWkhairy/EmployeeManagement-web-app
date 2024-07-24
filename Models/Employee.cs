using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement_web_app.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int? SubSectionId { get; set; }
        [ForeignKey("SubSectionId")]
        public SubSection? SubSection { get; set; }
    }
}
