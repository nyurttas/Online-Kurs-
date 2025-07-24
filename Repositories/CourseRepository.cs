using _9_EFOnlineCourseDB.Context;
using _9_EFOnlineCourseDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(AppDBContext context) : base(context)
        {

        }
    }
}
