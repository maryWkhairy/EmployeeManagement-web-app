using System.ComponentModel.DataAnnotations.Schema;
using static System.Collections.Specialized.BitVector32;

namespace EmployeeManagement_web_app.Models
{
    public class SubSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SectionId { get; set; }
        [ForeignKey("SectionId")]
        public Section? Section { get; set; }
    }
}