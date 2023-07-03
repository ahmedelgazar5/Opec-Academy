using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return context.Courses.ToList();
        }
    }
}
