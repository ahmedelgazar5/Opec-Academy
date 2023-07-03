using OpecDataBase.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEC_Academy_API.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Employee")]
        public int Created_BY { get; set; }
        public DateTime Created_At { get; set; }
        public Employee Employee { get; set; }
        //[ForeignKey("Course")]
        //public int Crs_ID { get; set; }
        //public Course Course { get; set; }
    }
}
