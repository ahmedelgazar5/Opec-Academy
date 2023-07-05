using OpecDataBase.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEC_Academy_API.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public int Price { get; set; }
        public DateTime Created_At { get; set; }
        public bool IsDeleted { get; set; } = false;
        [ForeignKey("Employee")]
        public int Created_BY { get; set; }
        public Employee? Employee { get; set; }
        public List<Subject>? Subjects { get; set; } = new List<Subject>();
        public List<Enrollments>? Enrollments { get; set; } = new List<Enrollments>();

        //public List<Student> Students { get; set; } = new List<Student>();
        //public List<Branch_Course> branch_Courses { get; set; } = new List<Branch_Course>();
    }
}
