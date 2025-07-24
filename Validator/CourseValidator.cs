using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_EFOnlinecourseDB.Entities;
using FluentValidation;

namespace _9_EFOnlinecourseDB.Validator
{
    public class CourseValidator :AbstractValidator<Course>
    {

        public CourseValidator ()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .Length(3, 20);



        }
    }
}
