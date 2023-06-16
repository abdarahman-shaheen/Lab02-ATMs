using Lab02_ATMs;
using Newtonsoft.Json.Linq;

namespace TestATM
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000, 1000,1000)]
        public void TestViewBalance(decimal testNumber, decimal excepted ,decimal value)
        {
            Program.balance =value ;
            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.ViewBalance(testNumber));


            //Assert

        }

        [Theory]
        [InlineData(1500,1000,1000)]
        [InlineData(100,900,1000)]
        public void TestAmountLessThanBalanceInWithdrow(decimal testNumber, decimal excepted, decimal value)
        {
            Program.balance = value;

            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Withdraw(testNumber));


            //Assert

        }

        [Theory]
        [InlineData(-500, 1000,1000)]

        public void TestAmountLessThanZeroInWithdrow(decimal testNumber, decimal excepted, decimal value)
        {
            Program.balance = value;

            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Withdraw(testNumber));


            //Assert

        }
        [Theory]
        [InlineData(150, 1150,1000)]
        [InlineData(-100, 1000,1000)]
        public void TestNegativeNumInDepost(decimal testNumber, decimal excepted, decimal value)
        {
            Program.balance = value;

            //Arrange
            //decimal testNumber = 1500;

            //Act
            // decimal result = Program.Withdraw(testNumber);

            Assert.Equal(excepted, Program.Diposit(testNumber));


            //Assert

        }
       
    }
}