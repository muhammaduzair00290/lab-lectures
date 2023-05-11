/*for ( int i = 0; i< 10; i++)//only use while we know the values 
{
    if (i % 2 == 0)
    {
        if (i==0)
        {
            continue;
        }
        Console.WriteLine("This is a even number");
    }
}*/

//while
/*int j = 0;
while (j < 10)
{
    if (j % 2 == 0)
    {
        if (j == 0)
        {
            continue;
        }
        Console.WriteLine("This is a Even Number" + j);
    }
}*/

//while another method
/*int k = 0;
bool first = true;
while (k < 10)
{
    if (k % 2 == 0)
    {
        if (k == 0 && first == true)
        {
            if (first)
            {
                first = false;
                continue;
            }
        }
        Console.WriteLine("This is a Even Number" + k);
        k++;
    }
}*/

// new method but errors so fix it

bool isContinue = true;
bool isFirst = true;
do
{
    if (!isFirst)
    {
        Console.WriteLine("press any key to continue....");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine("Main menu");
    Console.WriteLine("--------------");
    Console.WriteLine("1: ghand ka calculator");
    Console.WriteLine("2.Main menu");
    Console.WriteLine("3.Main menu");
    Console.Write(">>");

    int choice = Convert.ToInt32((Console.ReadLine()));
    switch (choice)
    {
        case 1:
            investmentCalculator();
            break;
        case 2:
            Console.WriteLine("This is a array demo");
            break;
        case 3:
            Console.WriteLine("this a demo");
            break;
        default:
            Console.WriteLine("HEllo World");
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

    float i = 10 / 0.1f;

    //int a = (int)(p + p * i * n)

    int a = (int)(p * (Math.Pow(1 + i, n)));
    Console.WriteLine($"Your investment is = {p} ");
    Console.WriteLine($"duration = {n:N0}");
    Console.WriteLine($"Total Amount Included Profit = {a}");

    int grossprofit = a = p;
    Console.WriteLine($"Gross Profit = {grossprofit}");

    int tax = 0;
    if (grossprofit > 500000)
    {
        tax = (int)(grossprofit * 0.15);
    }
    else
    {
        tax = (int)(grossprofit * 0.10);
    }
    int netprofit = grossprofit - tax;
    Console.WriteLine("The tax you paid:" + tax);

    Console.WriteLine("Now your Amount is " + a + "after investment of " + p + " with percentage of" + i);
    Console.ReadLine();
}