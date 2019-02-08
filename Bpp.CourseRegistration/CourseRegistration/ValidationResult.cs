namespace Bpp.CourseRegistration.CourseRegistration
{
    internal class ValidationResult
        : IValidationResult
    {
        public string Message { get; set; }

        public bool Success { get; set; }
    }
}
