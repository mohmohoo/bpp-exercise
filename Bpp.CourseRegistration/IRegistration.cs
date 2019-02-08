using System.Collections.Generic;

namespace Bpp.CourseRegistration
{
    public interface IRegistration
    {
        IRegistrationResult Register(ILearner learner, ICourse course);

        List<ILearner> GetLearners(ICourse course);
    }
}
