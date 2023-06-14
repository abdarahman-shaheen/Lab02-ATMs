using Lab02_ATMs;

namespace TestATM
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1500,0)]
        [InlineData(100,900)]
        public void TestAmountInWithdrow(decimal testNumber, decimal excepted )
        {
            //Arrange
            //decimal testNumber = 1500;

            //Act
           // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Withdraw(testNumber));


            //Assert

        }

        [Theory]
        [InlineData(150, 1050)]
        [InlineData(-100, 0)]
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