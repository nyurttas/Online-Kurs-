namespace _9_EFOnlineCourseDB.Entities
{
    public class Instructor : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public string? TCKimlikNo { get; set; }
        public string? Email { get; set; }
        public string? Professions { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
