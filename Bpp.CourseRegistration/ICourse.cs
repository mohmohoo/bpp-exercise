using Bpp.CourseRegistration.CourseRegistration;

namespace Bpp.CourseRegistration
{
    public interface ICourse
    {
        string Title { get; }

        string Description { get; }

        int Cost { get; }

        CourseType CourseType { get; }

        int? SeatLimit { get; }
    }
}
