using System.Collections.Generic;

namespace Bpp.CourseRegistration
{
    public interface IDataStore
    {
        List<ICourse> GetCourses(string email);

        bool Register(ILearner learner, ICourse course);

        int GetStudentCounts(ICourse course);

        bool IsRegistered(ILearner learner, ICourse course);

        List<ILearner> GetLearners(ICourse course);
    }
}
