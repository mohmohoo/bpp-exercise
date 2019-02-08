namespace Bpp.CourseRegistration.CourseRegistration
{
    internal class RegistrationResult
            : IRegistrationResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
