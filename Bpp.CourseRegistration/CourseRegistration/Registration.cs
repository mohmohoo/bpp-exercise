using System.Collections.Generic;

namespace Bpp.CourseRegistration.CourseRegistration
{
    public class Registration
        : IRegistration
    {
        private IRegistrationValidator _registrationValidator;
        private IDataStore _dataStore;


        public Registration(IRegistrationValidator validator, IDataStore dataStore)
        {
            _registrationValidator = validator;
            _dataStore = dataStore;
        }

        public List<ILearner> GetLearners(ICourse course)
        {
            return _dataStore.GetLearners(course);
        }

        public IRegistrationResult Register(ILearner learner, ICourse course)
        {
            var validationResult = _registrationValidator.Validate(learner, course);

            if (!validationResult.Success)
            {
                return validationResult.ToRegistrationResult();
            }

            var success = _dataStore.Register(learner, course);

            if (success)
            {
                return new RegistrationResult
                {
                    Success = true,
                    Message = "Registered"
                };
            }

            return new RegistrationResult
            {
                Success = false,
                Message = "Unable to save registration"
            };
        }
    }
}
