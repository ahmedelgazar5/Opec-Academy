using OPEC_Academy_API.Models;
using OpecDataBase.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecAcademyManager.BLL.DTO.StudentDTO
{
    public class StudentCoursesBranchesDTO
    {
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
        public List<string> Religions { get; set; }
        public string Phone { get; set; }
        public string Mobile1 { get; set; }
        public string? Mobile2 { get; set; }
        public string? Military { get; set; }
        public string Personal_Image { get; set; }
        public string Quaification_Image { get; set; }
        public string Identity_Image { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Branches { get; set; }
        public int Paid { get; set; }
    }
}
