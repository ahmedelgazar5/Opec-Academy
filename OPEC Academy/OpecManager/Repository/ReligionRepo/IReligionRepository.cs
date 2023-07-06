using OpecDataBase.DAL.Models;

namespace OpecAcademyManager.BLL.Repository.ReligionRepo
{
    public interface IReligionRepository
    {
        List<Religion> GetAll();
    }
}