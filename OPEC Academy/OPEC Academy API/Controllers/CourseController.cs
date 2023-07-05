using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OPEC_Academy_API.Models;
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
        public IActionResult GetAll()
        {
            var courses = courseRepository.GetAll();    
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetById(int id)
        {
            Course course = courseRepository.GetDyId(id);
            if(course == null)
            {
                return NotFound();
            }
            else
            {
                return course;
            }
            
        }

        [HttpPost]
        public ActionResult Add(Course course)
        {
            if (course == null)
            {
                return BadRequest();
            }
            else
            {
                if (ModelState.IsValid == true)
                {
                    courseRepository.Add(course);
                    courseRepository.Save();
                    return CreatedAtAction("GetById",new {id = course.ID} , course);
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update(Course course , int id)
        {
            if (course == null)
            {
                return BadRequest();
            }
            if (course.ID != id)
            {
                return BadRequest();
            }

                if (ModelState.IsValid == true)
                {
                    courseRepository.Update(course);
                    courseRepository.Save();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Course course = courseRepository.GetDyId(id);
            if (course == null)
                return NotFound();
            else
            {
                courseRepository.Delete(id);
                courseRepository.Save();
                return Ok(course);
            }
        }
    }
}
