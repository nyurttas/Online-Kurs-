using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Entities
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public string? TCKimlikNo { get; set; }
        public DateOnly BirthDate { get; set; }
        public ICollection<Registration>? Registrations { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
    }
}
