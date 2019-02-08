namespace Bpp.CourseRegistration
{
    public interface IRegistrationValidator
    {
        IValidationResult Validate(ILearner learner, ICourse course);
    }
}
