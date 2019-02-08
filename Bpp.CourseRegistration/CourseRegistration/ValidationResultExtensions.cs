namespace Bpp.CourseRegistration.CourseRegistration
{
    internal static class ValidationResultExtensions
    {
        public static IRegistrationResult ToRegistrationResult(this IValidationResult validationResult)
        => new RegistrationResult
        {
            Success = validationResult.Success,
            Message = validationResult.Message
        };
    }
}
