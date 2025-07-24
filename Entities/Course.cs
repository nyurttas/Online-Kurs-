namespace _9_EFOnlineCourseDB.Entities
{
    public class Course : BaseEntity
    {
        public string? Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Guid InstructorID { get; set; }
        public Instructor? Instructor { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Registration>? Registrations { get; set; }

    }
}
