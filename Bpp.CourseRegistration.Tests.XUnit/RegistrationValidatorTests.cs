using Moq;
using Xunit;

namespace Bpp.CourseRegistration.Tests.XUnit
{
    public class RegistrationValidatorTests
    {
        [Theory]
        [InlineData(10, 10, false, false, "Course has a Seat limit of 10")]
        public void ValidateTests(int existingStudentCount, int? seatLimit, bool isRegistered, 
            bool expectedSuccess, string expectedMessage)
        {
            var courseMock = new Mock<ICourse>();

            courseMock
                .Setup(x => x.SeatLimit)
                .Returns(seatLimit);


            
            var dataStoreMock = new Mock<IDataStore>();
            dataStoreMock.Setup(x => x.GetStudentCounts(courseMock.Object));
        }
    }
}
