using System.Collections.Generic;

namespace Bpp.CourseRegistration
{
    public interface ICatalogue
    {
        List<ICourse> GetCourses(ILearner learner);
    }
}
