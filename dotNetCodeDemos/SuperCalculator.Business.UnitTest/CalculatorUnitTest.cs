namespace SuperCalculator.Business.UnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        Calculator target = null;
        [TestInitialize]
        public void Init()
        {
            target = new Calculator();
        }

        [TestCleanup]
        public void Cleanup() 
        {
            target = null;
        }

        [TestMethod]
        // for a valid input should give valid result
        public void Sum_WithValidInput_ProvidesValidResult()
        {
            // write only simple statements
            // never write
            // conditional stmts
            // looping
            // try...catch


            // AAA
            // Arrange
            int a = 2; int b = 4;int expected = 6;
            //Calculator target = new Calculator();

            // Act
            int actual = target.Sum(a, b);
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(NonZeroNumberException))]
        public void Sum_WithZeroOrNegativeInput_ShouldThrowsExp()
        {
            //Calculator target = new Calculator();
            target.Sum(0, -1);
            //
        }
        [TestMethod, ExpectedException(typeof(NonEvenNumberException))]
        public void Sum_WithNonEvenInput_ThrowsExp()
        {
            //Calculator target = new Calculator();
            target.Sum(3,7);
        }
    }
}