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
        [DataRow(1,0)]
        [DataRow(0,0)]
        [DataRow(-1,0)]
        [DataRow(-1,-1)]
        [ExpectedException(typeof(NonZeroNumberException))]
        public void Sum_WithZeroOrNegativeInput_ShouldThrowsExp(int a, int b)
        {
            //Calculator target = new Calculator();
            target.Sum(a,b);
            //
        }
        [TestMethod, ExpectedException(typeof(NonEvenNumberException))]
        [DataRow(1,2)]
        [DataRow(2, 1)]
        [DataRow(1, 1)]
        public void Sum_WithNonEvenInput_ThrowsExp(int a, int b)
        {
            //Calculator target = new Calculator();
            target.Sum(a,b);
        }
    }
}