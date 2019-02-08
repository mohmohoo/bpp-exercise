using Bpp.CourseRegistration.CourseRegistration;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Bpp.CourseRegistration.Tests.XUnit
{
    public class CatalogueTests
    {
        [Theory]
        [InlineData("moh", "moh@gmail.com", 0)]
        [InlineData("john", "john@gmail.com", 2)]
        [InlineData("emily", "emily@gmail.com", 1)]
        [InlineData("joyce", "joyce@gmail.com", 3)]
        public void GetCoursesTest(string name, string studentEmail, int expectedCourseCount)
        {
            var lawCourse = new Mock<ICourse>();
            var accountingCourse = new Mock<ICourse>();
            var managementCourse = new Mock<ICourse>();

            var johnCourses = new List<ICourse> { lawCourse.Object, accountingCourse.Object };
            var emilyCourses = new List<ICourse> { managementCourse.Object };
            var joyceCourse = new List<ICourse> { lawCourse.Object, accountingCourse.Object, managementCourse.Object };

            var dataStoreMock = new Mock<IDataStore>();
            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => email.StartsWith("john"))))
                .Returns(johnCourses);

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => email.StartsWith("emily"))))
                .Returns(emilyCourses);

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => email.StartsWith("joyce"))))
                .Returns(joyceCourse);

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => email.StartsWith("moh"))))
                .Returns(new List<ICourse>());

            var learnerMock = new Mock<ILearner>();

            learnerMock
                .Setup(x => x.Name)
                .Returns(name);

            learnerMock
                .Setup(x => x.Email)
                .Returns(studentEmail);

            var target = new Catalogue(dataStoreMock.Object);

            var actualCourseCount =  target.GetCourses(learnerMock.Object).Count;

            Assert.Equal(expectedCourseCount, actualCourseCount);
        }
    }
}
