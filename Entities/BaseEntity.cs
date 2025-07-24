using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Entities
{
    public class BaseEntity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
