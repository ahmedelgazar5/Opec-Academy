using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OPEC_Academy_API.Models;
using OpecDataBase.DAL;
using OpecDataBase.DAL.Models;

namespace OpecAcademyManager.BLL.Repository
{
    public class CourseRepository : ICourseRepository
    {
        OpecAcademyContext context;
        public CourseRepository(OpecAcademyContext context)
        {
            this.context = context;
        }
        
        public List<Course> GetAll()
        {
            return context.Courses.Where(c=>c.IsDeleted == false).ToList();
        }
        public Course GetDyId(int id)
        {
            return context.Courses.FirstOrDefault(c=>c.ID == id && c.IsDeleted == false);
        }
        public void Add(Course course)
        {
             context.Courses.Add(course);
        }
        public void Update(Course course)
        {
            context.Courses.Update(course);
        }
        public void Delete(int id)
        {
           Course course = GetDyId(id);
            course.IsDeleted = true;    
        }
        public void Save()
        {
            context.SaveChanges();  
        }
    }
}
