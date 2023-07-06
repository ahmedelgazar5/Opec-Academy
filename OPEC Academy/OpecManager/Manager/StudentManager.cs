using OPEC_Academy_API.Models;
using OpecAcademyManager.BLL.DTO.StudentDTO;
using OpecAcademyManager.BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecAcademyManager.BLL.Manager
{
    public class StudentManager 
    {
        IStudentRepository studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public Task<List<StudentCoursesBranchesDTO>> GetAll()
        {
            List<Student> students = studentRepository.GetAll();

            List<StudentCoursesBranchesDTO> studentCoursesBranchesDTOs = new List<StudentCoursesBranchesDTO>();
            foreach (Student student in students)
            {
                StudentCoursesBranchesDTO studentCoursesBranchesDTO = new StudentCoursesBranchesDTO()
                {
                    Ar_Name = student.Ar_Name,
                    Address = student.Address,
                    Apllying_Date = student.Apllying_Date,
                    Birth_Date = student.Birth_Date,
                    En_Name = student.En_Name,
                    Gender = student.Gender,
                    Military = student.Military,
                    Identity_Image = student.Identity_Image ,
                    Mobile1 = student.Mobile1,  
                    Mobile2 = student.Mobile2,
                    Personal_Image = student.Personal_Image,    
                    Phone = student.Phone,  
                    Quaification_Image = student.Quaification_Image,    
                    Qualification = student.Qualification,
                    Qualification_Year = student.Qualification_Year,
                    Recommend = student.Recommend,
                    SSN = student.SSN,  
                    Studying_Year = student.Studying_Year,
                    
                };
            }
        }
    }
}
