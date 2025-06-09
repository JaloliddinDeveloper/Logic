using Logic.Classes;
using Moq;
using Xunit;

namespace Logic.Unit.Tests.Tests
{
    public class Math
    {
        private readonly Mock<Promlem1> logicMathMock;

        public Math()
        {
            logicMathMock = new Mock<Promlem1>();
        }

        [Fact]
        public void Add_ShouldReturnMockedValue()
        {
            // Arrange
            logicMathMock.Setup(x => x.Add(2, 3)).Returns(100);

            // Act
            int result = logicMathMock.Object.Add(2, 3);

            // Assert
            Assert.Equal(100, result);
        }
    }
}
