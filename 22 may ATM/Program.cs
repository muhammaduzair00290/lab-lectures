

bool iscon = true;
bool isstop = true;
int balance = 1000;





Console.WriteLine("Akhuwat Bank ATM");
Console.WriteLine("Please Enter Your PIN");
int pin = Convert.ToInt32(Console.ReadLine());
if (pin == 12345)
{
    Console.WriteLine("Welcome ATM");

    do
    {

        if (!isstop)
        {
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

        }

        Console.WriteLine("1: Withdraw Money");
        Console.WriteLine("2: Deposit Money");
        Console.WriteLine("3: Balance Inquiry");
        Console.WriteLine("4: Transfer Money");
        Console.WriteLine("Exit");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {

            case 1:
                // Withdraw Money
                Console.WriteLine("Enter The Amount To Withdraw");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                while (withdraw < 500)
                {
                    Console.WriteLine(" you are entering small amount anter agian ");
                    withdraw = Convert.ToInt32(Console.ReadLine());
                   
                }
                Console.WriteLine($"You Successfully withdraw {withdraw} ");
                Console.WriteLine($"Your Available Balance is {balance - withdraw} ");
                break;


            // =========================================================================================

            case 2:
                // Deposit Money
                Console.WriteLine("Enter The Amount To Deposit");
                int deposit = Convert.ToInt32(Console.ReadLine());
                while (deposit <0)
                {
                    Console.WriteLine(" you are entering invalid amount enter again ");
                    deposit = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"You successfully deposit {deposit}");
                Console.WriteLine($"now your balance is  {deposit + balance}");
                break;


            // ==========================================================================================

            case 3:
                // Balance Inquiry
                Console.WriteLine($"Your Balance is {balance}");
                break;


            // ==========================================================================================

            case 4:
                // Transfer Money
                Console.WriteLine("Please Enter Number to Transfer");
                long mobilenumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter OTP 6534");
                int otp = Convert.ToInt32(Console.ReadLine());
                if (otp == 6534)
                {
                    Console.WriteLine("enter amount");
                    int transfer = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"are you sure 'Y' for (Yes) and 'N' for (NO)");
                    string confirm = (Console.ReadLine());
                    if (confirm == "y")
                    {
                        Console.WriteLine($"You successfully transfer money to +92{mobilenumber}");
                        Console.WriteLine($"Your available balance is {balance - transfer}");
                    }
                    else
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Sorry invalid otp code please write correct one");
                }
                break;

            default:
                Console.WriteLine();
                break;

        }
        isstop = false;

    } while (iscon);


}
else
{
    Console.WriteLine("Your Entered Wrong PIN Please try again");
   
}


// ===============================================================================================

