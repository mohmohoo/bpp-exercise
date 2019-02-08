namespace Bpp.CourseRegistration.CourseRegistration
{
    internal class Course
        : ICourse
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public CourseType CourseType { get; set; }

        public int? SeatLimit { get; set; }
    }
}
