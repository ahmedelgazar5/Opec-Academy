using OPEC_Academy_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecDataBase.DAL.Models
{
    public class Religion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public bool IsDeleted { get; set; } = false;
    }
}
