using _9_EFOnlineCourseDB.Abstract;
using _9_EFOnlineCourseDB.Entities;
using _9_EFOnlineCourseDB.Repositories;
using _9_EFOnlineCourseDB.Validator;
using FluentValidation.Results;

namespace _9_EFOnlineCourseDB.Managers
{
    public class StudentManager : IRepository<Student>
    {
        private StudentRepository _studentRepository;
        public StudentManager(StudentRepository sRepo)
        {
            _studentRepository = sRepo;
        }
        public void Create(Student entity)
        {
            #region 1. Yontem
            //if (string.IsNullOrEmpty(entity.Name))
            //{
            //    throw new Exception("Lütfen öğrenci adı alanını doldurunuz.");
            //}

            //if (entity.TCKimlikNo?.Length!=11)
            //{
            //    throw new Exception("TC Kimlik No 11 karakter olmalıdır.");
            //}
            #endregion

            #region 2.Yontem
            //FLUENT VALIDATION
            //install-package FluentValidation
            StudentValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);

            if (!result.IsValid) {
                throw new Exception(string.Join(",", result.Errors));
            }

            _studentRepository.Create(entity);
            #endregion

        }

        public void DeleteByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Student>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Student? GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
