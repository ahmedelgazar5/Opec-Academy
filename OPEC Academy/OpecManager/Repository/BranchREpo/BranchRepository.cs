using Microsoft.EntityFrameworkCore;
using OPEC_Academy_API.Models;
using OpecDataBase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecAcademyManager.BLL.Repository.BranchREpo
{
    public class BranchRepository : IBranchRepository
    {
        OpecAcademyContext context;
        public BranchRepository(OpecAcademyContext context)
        {
            this.context = context;
        }

        public List<Branch> GetAll()
        {
            return context.Branches.Include(n=>n.Supervisor).Where(s => s.IsDeleted == false).ToList();
        }
        public Branch GetDyId(int id)
        {
            return context.Branches.Include(n => n.Supervisor).FirstOrDefault(s => s.ID == id && s.IsDeleted == false);
        }
        public void Add(Branch branch)
        {
            context.Branches.Add(branch);
        }
        public void Update(Branch branch)
        {
            context.Branches.Update(branch);
        }
        public void Delete(int id)
        {
            Branch branch = GetDyId(id);
            branch.IsDeleted = true;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
