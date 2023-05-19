using Moq;
using MyShapes.Web.Controllers;
using MyShapes.Web.Repositories;
using System.Runtime.InteropServices;

namespace MyShapes.Test
{
    public class UnitTests
    {
        private int _testWidth = 4;
        private int _testHeight = 2;

        [Fact]
        public void Rettangolo_CalcArea_CorrectResult()
        {
            // Arrange
            var sut = new Rettangolo(_testWidth, _testHeight);

            // Act
            var area = sut.CalcArea();

            // Assert

            Assert.True(area == 4 * 2);

        }

        [Fact]
        public void Rettangolo_CalcArea_BecomesHalf()
        {
            // Arrange
            var sut = new Rettangolo(_testWidth, _testHeight);

            sut.SetWidth(sut.GetWidth() / 2);

            // Act
            var area = sut.CalcArea();

            // Assert
            Assert.True(area == _testWidth * _testHeight / 2);
        }

        [Fact]
        /// <summary>
        /// This test fails if we use <see cref="MyShapes.Quadrato_ThisBreaks_Liskov">
        /// </summary>
        public void Quadrato_CalcArea_BecomesHalf()
        {
            // Arrange
            var sut = new Quadrato(_testWidth);

            sut.SetWidth(sut.GetWidth() / 2);

            // Act
            var area = sut.CalcArea();

            // Assert
            Assert.True(area == _testWidth * _testHeight / 2);
        }

        [Fact]
        public void ShapesController_Get_NullParams_ThrowsException()
        {
            // Arrange
            var sut = new ShapesController(null, null);

            // Act
            //sut.Get(); See below (xUnit requires a lambda to catch Exceptions)

            // Assert
            Assert.Throws<NullReferenceException>(() => sut.Get());
        }

        /// <summary>
        /// We want to test how do the controller reacts ad exceptions in DB
        /// Say, from specs: "The controller shall return an empty set"
        /// </summary>
        [Fact]
        public void ShapesController_Get_DbFails_ReturnsEmptySet()
        {
            // Arrange
            var dbMock = new Mock<IShapeRepository>();
            // This db throws an Exception
            dbMock.Setup(x => x.GetShapes()).Throws<Exception>();

            var sut = new ShapesController(dbMock.Object,
                null /* We don't need mapper, for this use-case */);

            // Act
            var res = sut.Get();

            // Assert
            Assert.NotNull(res);
            Assert.Empty(res);
        }
    }
}
