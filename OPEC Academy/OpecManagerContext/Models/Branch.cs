using OpecDataBase.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEC_Academy_API.Models
{
    public class Branch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        //[ForeignKey("Supervisor")]
        public int Supervisor_ID { get; set; }
        public Employee Supervisor { get; set; }
        //[InverseProperty("Branch")]
        public List<Employee> Employees { get; set; }
        public List<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

        public bool IsDeleted { get; set; } = false;



    }
}
