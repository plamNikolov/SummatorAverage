using NUnit.Framework;

namespace Average.Tests
{
    [TestFixture]
    public class Tests
    {
        private Average Average;
        [SetUp]
        public void SetUp()
        {
            Average = new Average();
            System.Console.WriteLine("Test started:" + System.DateTime.Now);
        }
        [Test]
        public void Test_AvgTwoPossitiveNumbers()
        {
            //Arrange
            var values = new int[] {5, 8};
            double expected = 6.5;

            //Act
            double actual = Average.avg(values);

            //Assert
            Assert.AreEqual(expected, actual, "Average value should be equal to 6.5");
        }
        [Test]
        [Category("Critical")]
        public void Test_AvgTwoNegativeNumbers()
        {
            //Arrange
            var values = new int[] { -5, -8 };
            double expected = -6.5;

            //Act
            double actual = Average.avg(values);

            //Assert
            Assert.AreEqual(expected, actual, "Average value should be equal to -6.5");
        }
        [Test]
        public void Test_AvgOneNegativeOnePositiveNumbers()
        {
            //Arrange
            var values = new int[] { 5, -8 };
            double expected = -1.5;

            //Act
            double actual = Average.avg(values);

            //Assert
            Assert.AreEqual(expected, actual, "Average value should be equal to -1.5");
        }
        //[Test]
        public void Test_AvgEmptyArray()
        {
            double result = Average.avg(new int[] {  });

            Assert.That(result == 0);
        }
        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Test ended:" + System.DateTime.Now);
        }
    }
}