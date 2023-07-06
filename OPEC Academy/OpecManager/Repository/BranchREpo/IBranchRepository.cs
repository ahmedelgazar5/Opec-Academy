using OPEC_Academy_API.Models;

namespace OpecAcademyManager.BLL.Repository.BranchREpo
{
    public interface IBranchRepository
    {
      
        List<Branch> GetAll();
        Branch GetDyId(int id);
        void Add(Branch branch);
        void Update(Branch branch);
        void Delete(int id);
        void Save();
    }
}