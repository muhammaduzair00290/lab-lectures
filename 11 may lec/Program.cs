//// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" loops  ");
//for (int i = 0; i < 10; i++)
//{
//    if (i %2==0)
//    {
//        if (i==0)
//        {
//            continue;
//        }
//        Console.WriteLine($" {i} is an even number  ");
//    }
//}
//int b = 1;
//bool b2 = true;
//while(b< 10)
//{
//    if ((b%2)==0 || b==0)
//    {
//        if (b==0 && b2 )
//        {
//            b2 = false;
//            continue;
//        }
//        Console.WriteLine($"{b} is even no " );

//    }
//    b++;

//}
// do while 



bool isContinue = true;
bool isFirst = true;
do
{
    if (!isFirst)
    {
        Console.WriteLine(" PESS ANY KEY TO CONTINUE ");
        Console.ReadKey();
        Console.Clear();
    }

    Console.WriteLine(" main menu ");
    Console.WriteLine(" --------------");
    Console.WriteLine(" 1. investment calculator ");
    Console.WriteLine(" 2. user authentication");
    Console.WriteLine(" 3.  student marks ");
    Console.WriteLine(" 4. exit ");
    Console.Write(">>>");
    int choice = Convert.ToInt32(Console.ReadLine() ?? "0");
    switch (choice)
    {
        case 1:
            investmentCalculator();
            break;
        case 2:
            userAuthentication();
            break;
        case 3:
            stdMarks();
            break;
        case 4:
            isContinue = false;
            break;
        default:
            Console.WriteLine(" enter a valid value ");
            break;

    }
    isFirst = false;
}
while (isContinue);

static void investmentCalculator()
{
    
    
        Console.Write("Please enter your desired amount");
        string? temp = Console.ReadLine();
        int p = Convert.ToInt32(temp);

        Console.Write("Please enter your desired years");
        string? temp1 = Console.ReadLine();
        int n = Convert.ToInt32(temp1);

        float i =  0.1f;

        //int a = (int)(p + p * i * n)

        int a = (int)(p * (Math.Pow(1 + i, n)));
        Console.WriteLine($"Your investment is = {p} ");
        Console.WriteLine($"duration = {n}");
        Console.WriteLine($"Total Amount Included Profit = {a}");

        int grossProfit = a - p;
        Console.WriteLine($"Gross Profit = {grossProfit}");

        int tax = 0;
        if (grossProfit > 500000)
        {
            tax = (int)(grossProfit * 0.15);
        }
        else
        {
            tax = (int)(grossProfit * 0.10);
        }
        int netProfit = grossProfit - tax;
        Console.WriteLine("The tax you paid:" + tax);
    Console.WriteLine($"your net profit is {netProfit} ");
    Console.WriteLine("Now your Amount is " + a + "after investment of " + p + " with percentage of" + i);
        Console.ReadLine();
    
}
static void userAuthentication()
{
    Console.WriteLine(" enter your name ");
    string? name = Console.ReadLine();



    if (name.Length < 8 && name.Length <= 16)
    {
        Console.WriteLine($"name should be at least 9 digits long an i between 16 digits  ");
        Console.WriteLine(" enter a name in between range  ");
        name = Console.ReadLine();


    }
    else
    {
        Console.WriteLine(" okay name is enough ");
    }
    Console.WriteLine(" enter your password ");
    string? password = (Console.ReadLine());
    if (password.Length < 8)
    {
        Console.WriteLine(" password must be long ");
        Console.WriteLine(" enter a longer password ");
        password = Console.ReadLine();


    }
    else
    {
        Console.WriteLine(" okay password is good lets compare ");
    }
    Console.WriteLine(" enter your password again to compare   ");
    string? password1 = (Console.ReadLine());

    if (string.Equals(password, password1))
    {
        Console.WriteLine(" passwords are equal ");
    }

    else
    {
        Console.WriteLine(" passwords are not equal ");
    }

}
static void stdMarks()
{
    int r, m1, m2, m3, t;
    float p;
    string? n;
    Console.WriteLine("Enter Roll Number :");
    r = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Student Name :");
    n = Console.ReadLine();
    Console.WriteLine("Mark of Subject1 : ");
    m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Mark of Subject2 : ");
    m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Mark of Subject3 : ");
    m3 = Convert.ToInt32(Console.ReadLine());
    t = m1 + m2 + m3;
    p = t / 3.0f;
    Console.WriteLine("Total : " + t);
    Console.WriteLine("Percentage : " + p);

    if (p >= 1 && p < 33)
    {
        Console.WriteLine("you are fail");
    }
    if (p >= 34 && p < 50)

    {
        Console.WriteLine("Grade is C");
    }
     else if (p >= 50 && p <= 60)
    {
        Console.WriteLine("Grade is B");
    }
     else if (p > 60 && p <= 80)
    {
        Console.WriteLine("Grade is A");
    }
     else if (p > 80 && p <= 100)
    {
        Console.WriteLine("Grade is A+");
    }
    else
    {
        Console.WriteLine(" you ave entered the wrong details ");
    }
}

