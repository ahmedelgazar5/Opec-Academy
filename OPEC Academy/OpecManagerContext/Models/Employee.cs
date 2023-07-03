using OPEC_Academy_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecDataBase.DAL.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        [ForeignKey("Language")]
        public int Lang_Id { get; set; }
        public Language Language { get; set; }
        //[ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        //[InverseProperty("Supervisor")]
        public Branch Branch_Mng { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Payment> Payments { get; set; } = new List<Payment>();


    }
}
