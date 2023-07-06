using OPEC_Academy_API.Models;
using OpecDataBase.DAL;
using OpecDataBase.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecAcademyManager.BLL.Repository.ReligionRepo
{
    public class ReligionRepository : IReligionRepository
    {
        OpecAcademyContext context;
        public ReligionRepository(OpecAcademyContext context)
        {
            this.context = context;
        }

        public List<Religion> GetAll()
        {
            return context.Religions.Where(s => s.IsDeleted == false).ToList();
        }
    }
}
