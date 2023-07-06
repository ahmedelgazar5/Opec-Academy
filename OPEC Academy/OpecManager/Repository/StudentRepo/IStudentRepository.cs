using OPEC_Academy_API.Models;


namespace OpecAcademyManager.BLL.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetDyId(string ssn);
        void Add(Student student);
        void Update(Student student);
        void Delete(string ssn);
        void Save();
    }
}