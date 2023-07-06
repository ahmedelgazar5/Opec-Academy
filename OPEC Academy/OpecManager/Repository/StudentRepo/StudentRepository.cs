using OPEC_Academy_API.Models;
using OpecDataBase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecAcademyManager.BLL.Repository
{
    public class StudentRepository : IStudentRepository
    {
        OpecAcademyContext context;
        public StudentRepository(OpecAcademyContext context)
        {
            this.context = context;
        }

        public List<Student> GetAll()
        {
            return context.Students.Where(s=>s.IsDeleted == false).ToList();
        }
        public Student GetDyId(string ssn)
        {
            return context.Students.FirstOrDefault(s => s.SSN == ssn && s.IsDeleted == false);
        }
        public void Add(Student student)
        {
            context.Students.Add(student);
        }
        public void Update(Student student)
        {
            context.Students.Update(student);
        }
        public void Delete(string ssn)
        {
            Student student = GetDyId(ssn);
            student.IsDeleted = true;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
