using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpecAcademyManager.BLL.Repository;

namespace OPEC_Academy_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseRepository courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var courses = courseRepository.GetAll();    
            return Ok(courses);
        }
    }
}
