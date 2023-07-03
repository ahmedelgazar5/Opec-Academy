using OPEC_Academy_API.Models;

namespace OpecAcademyManager.BLL.Repository
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
    }
}