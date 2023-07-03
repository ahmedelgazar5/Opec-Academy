using OpecDataBase.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEC_Academy_API.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Student
    {
        [Key]
        public string SSN { get; set; }
        public string Ar_Name { get; set; }
        public string En_Name { get; set; }
        public string Recommend { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        public string Qualification_Year { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Apllying_Date { get; set; }
        public DateTime Studying_Year { get; set; }
        [ForeignKey("Religion")]
        public int Religion_ID { get; set; }
        public string Phone { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Military { get; set; }
        public string Personal_Image { get; set; }
        public string Quaification_Image { get; set; }
        public string Identity_Image { get; set; }
        [ForeignKey("Employee")]
        public int Created_BY { get; set; }
        public DateTime Created_At { get; set; }
        public Employee Employee { get; set; }
        public Religion Religion { get; set; }
        public List<Enrollments> Enrollments { get; set; } = new List<Enrollments>();
        //[ForeignKey("Course")]
        //public int Crs_ID { get; set; }
        //public Course Course { get; set; }
        //[ForeignKey("Branch")]
        //public int Branch_ID { get; set; }
        //public Branch Branch { get; set; }
        //public List<Payment> Payments { get; set; } = new List<Payment>();

    }
}
