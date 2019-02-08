namespace Bpp.CourseRegistration.CourseRegistration
{
    public class RegistrationValidator
        : IRegistrationValidator
    {
        private readonly IDataStore _dataStore;

        public RegistrationValidator(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public IValidationResult Validate(ILearner learner, ICourse course)
        {
            var studentsCount = _dataStore.GetStudentCounts(course);

            if (course.SeatLimit.HasValue && studentsCount == course.SeatLimit.Value)
            {
                return Fail($"Course has a Seat limit of {course.SeatLimit.Value}");
            }

            if (_dataStore.IsRegistered(learner, course))
            {
                return Fail($"Student '{learner.Name}' is already registered for course '{course.Title}'");
            }

            return Success();
        }

        private IValidationResult Success()
            => new ValidationResult
            {
                Message = "Valid",
                Success = true
            };

        private IValidationResult Fail(string message)
            => new ValidationResult
            {
                Message = message,
                Success = false
            };

    }
}
