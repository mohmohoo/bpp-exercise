using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Bpp.CourseRegistration.Tests.MsTest
{
    [TestClass]
    public class CatalogueTest
    {
        private Mock<IDataStore> dataStoreMock;
        [TestInitialize]
        public void Setup()
        {
            var aCourse = new Mock<ICourse>();
            var bCourse = new Mock<ICourse>();
            var cCourse = new Mock<ICourse>();
            var dCourse = new Mock<ICourse>();

            var johnCourses = new List<ICourse> { aCourse.Object, bCourse.Object };
            var emilyCourses = new List<ICourse> { cCourse.Object };
            var joyceCourse = new List<ICourse> { aCourse.Object, bCourse.Object, cCourse.Object, dCourse.Object };

            dataStoreMock = new Mock<IDataStore>();

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => (email ?? "").Equals("john@gmail.com"))))
                .Returns(johnCourses);

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => (email ?? "").Equals("emily@gmail.com"))))
                .Returns(emilyCourses);

            dataStoreMock
                .Setup(x => x.GetCourses(It.Is<string>(email => (email ?? "").Equals("joyce@gmail.com"))))
                .Returns(joyceCourse);

        }

        [TestMethod]
        [InlineData()]
        public int GetCoursesTest()
        {
        }
    }
}
