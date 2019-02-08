using System.Collections.Generic;

namespace Bpp.CourseRegistration.CourseRegistration
{
    public class Catalogue
        : ICatalogue
    {
        private readonly IDataStore _dataStore;

        public Catalogue(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public List<ICourse> GetCourses(ILearner learner)
        {
            return _dataStore.GetCourses(learner.Email);
        }
    }
}
