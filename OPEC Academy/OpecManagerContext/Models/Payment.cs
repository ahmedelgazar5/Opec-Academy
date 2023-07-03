using OpecDataBase.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEC_Academy_API.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public int Paid { get; set; }
        public DateTime Date_Payment { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Employee")]
        public int Created_BY { get; set; }
        public DateTime Created_At { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Student_Course_Branch")]
        public int Enroll_ID { get; set; }
        public Enrollments Student_Course_Branch { get; set; }

        //    [ForeignKey("Student")]
        //    public int Std_ID { get; set; }
        //    public Student Student { get; set; }
    }
}
