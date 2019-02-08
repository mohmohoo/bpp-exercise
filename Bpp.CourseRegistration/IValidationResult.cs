namespace Bpp.CourseRegistration
{
    public interface IValidationResult
    {
        string Message { get; }

        bool Success { get; }
    }
}
