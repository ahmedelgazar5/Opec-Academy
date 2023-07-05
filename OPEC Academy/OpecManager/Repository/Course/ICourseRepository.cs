using OPEC_Academy_API.Models;

namespace OpecAcademyManager.BLL.Repository
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        Course GetDyId(int id);
        void Add(Course course);
         void Update(Course course);
         void Delete(int id);
         void Save();
    }
}