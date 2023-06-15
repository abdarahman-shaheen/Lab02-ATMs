namespace Lab02_ATMs
{
    public class Program
    {
        public static decimal balance = 1000;

        static void Main(string[] args)
        {

            UserInterface();
        }
        public static void UserInterface()
        {
            Console.WriteLine("Hello in your account");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.View Balance");
                Console.WriteLine("2.Withdrow");
                Console.WriteLine("3.Diposite");
                Console.WriteLine("4.Exit");
                int number;
                string num = Console.ReadLine();
                number = Convert.ToInt32(num);

                switch (number)
                {
                    case 1:
                        decimal outputBalance = ViewBalance(balance);
                        Console.WriteLine($"You have {outputBalance}$ in your account");
                        break;
                    case 2:
                        Console.WriteLine("Add amount to your account to withdraw");
                        decimal Amount = Convert.ToDecimal(Console.ReadLine());
                        decimal outputWithdrow = Withdraw(Amount);
                        Console.WriteLine($"You have in Account Now {outputWithdrow}$ ");

                        break;
                    case 3:

                        Console.WriteLine("Add amount to your account to diposit");
                        decimal Amounts = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Your balance Now {Diposit(Amounts)}");
                        break;
                    default:
                        flag = false;
                        break;
                }

            }


        }
        public static decimal ViewBalance( decimal Testbalance)
        {
            if(Testbalance == balance)
                return balance;
            else
            {
                return 0;

            }



        }
        public static decimal Withdraw(decimal Amount)
        {
            if(Amount < 0 ){
                Console.WriteLine("You can't withdraw into your account with an amount less than zero");
                return -1;
            }
            if (balance < Amount)
            {
                Console.WriteLine("you dont have this Amount in your account");
                return 0;
            }
            balance -= Amount;
            return balance;
        }
        public static decimal Diposit(decimal Amount)
        {

            if (Amount < 0)
            {
                Console.WriteLine("you can't add a negative amount");
                return 0;
            }
            balance += Amount;
            return balance;
        }

    }

}