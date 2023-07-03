using OPEC_Academy_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecDataBase.DAL.Models
{
    public class Enrollments
    {
        public int ID { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        [ForeignKey("Branch")]
        public int Branch_Id { get; set; }
        [ForeignKey("Student")]
        public string Student_Id { get; set; }
        public Course Course { get; set; }
        public Branch Branch { get; set; }
        public Student Student { get; set; }
        public List<Payment> payments { get; set; } = new List<Payment>();

    }
}
