namespace _9_EFOnlineCourseDB.Entities
{
    public class Registration : BaseEntity
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }

        public Guid CourseID { get; set; }
        public Course? Course { get; set; }
        public Guid StudentID { get; set; }
        public Student? Student { get; set; }
    }
}
