using _9_EFOnlineCourseDB.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Validator
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Name)
                  .NotEmpty()
                  .WithMessage("Öğrenci adı boş bırakılamaz.")
                  .Length(3, 20)
                  .WithMessage("Öğrenci adı 3-20 karakter arasında olmalıdır.");

            RuleFor(s => s.TCKimlikNo)
                  .NotEmpty()
                  .WithMessage("TC Kimlik alanı boş bırakılamaz.")
                  .Length(11)
                  .WithMessage("TC Kimlik No alanı 11 karakter olmalıdır.")
                  .Matches("^[0-9]+$")
                  .WithMessage("TC Kimlik No yalnızca rakamlardan oluşmalıdır");

            RuleFor(c => c.BirthDate)
                .NotEmpty()
                .WithMessage("Doğum tarihi alanı boş bırakılamaz.")
                .LessThan(DateOnly.FromDateTime(DateTime.Now));

        }
    }
}
