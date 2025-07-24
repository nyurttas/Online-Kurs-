namespace _9_EFOnlineCourseDB.Entities
{
    public class ExamResult : BaseEntity
    {
        public byte ExamNote { get; set; }
        public Guid StudentID { get; set; }
        public Guid ExamID { get; set; }
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }
    }
}
