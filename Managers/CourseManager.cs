using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_EFOnlinecourseDB.Abstract;
using _9_EFOnlinecourseDB.Entities;
using _9_EFOnlinecourseDB.Repositories;
using _9_EFOnlinecourseDB.Validator;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;


namespace _9_EFOnlinecourseDB.Managers
{
    public class CourseManager : IRepository<Course>
    {
        private CourseRepository _courseRepository;
        public CourseManager(CourseRepository cRepo)
        {
            _courseRepository = cRepo;  
        }


        public void Create(Course entity)
        {
            CourseValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _courseRepository.Create(entity);
        }

        public void DeleteByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz");

            }
            _courseRepository.DeleteByID(id);
        }

        public List<Course>? GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course? GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz");
            }
            return _courseRepository.GetByID(id);
        }

        public void Update(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }
}
