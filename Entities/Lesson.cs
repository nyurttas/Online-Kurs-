namespace _9_EFOnlineCourseDB.Entities
{
    public class Lesson : BaseEntity
    {
        public string? Name { get; set; }
        public byte Duration { get; set; }
        public string? Content { get; set; }
        public Guid CourseID { get; set; }
        public Course? Course { get; set; }
    }
}
