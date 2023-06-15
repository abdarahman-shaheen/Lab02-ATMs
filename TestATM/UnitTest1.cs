using Lab02_ATMs;

namespace TestATM
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000, 1000)]
        public void TestViewBalance(decimal testNumber, decimal excepted)
        {
            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.ViewBalance(testNumber));


            //Assert

        }

        [Theory]
        [InlineData(1500,1150)]
        [InlineData(100,1050)]
        public void TestAmountLessThanBalanceInWithdrow(decimal testNumber, decimal excepted )
        {
            //Arrange
            //decimal testNumber = 1500;

            //Act
           // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Withdraw(testNumber));


            //Assert

        }

        [Theory]
        [InlineData(-500, 1150)]

        public void TestAmountLessThanZeroInWithdrow(decimal testNumber, decimal excepted)
        {
            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Withdraw(testNumber));


            //Assert

        }
        [Theory]
        [InlineData(150, 1150)]
        [InlineData(-100, 1150)]
        public void TestNegativeNumInDepost(decimal testNumber, decimal excepted)
        {
            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Diposit(testNumber));


            //Assert

        }
       
    }
}