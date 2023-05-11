// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" checking prime no ");
//Console.Write("Enter any number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//int f = 1;
//int i = 2;
//while (i < num1 || num1 == 1)
//{
//    if (num1 == 1)
//    {
//        f = 0;
//        break;
//    }
//    if (num1 % i == 0)
//    {
//        f = 0;
//        break;
//    }

//    i++;
//}
//if (f == 1)
//    Console.WriteLine(num1 + " is a Prime Number");
//else
//    Console.WriteLine(num1 + " is not a Prime Number");
//Console.WriteLine(" checking prime no ");
Console.Write("Enter any number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int f = 1;
int i = 2;
while (i < num1 || num1 == 1)
{

    if (num1 % i == 0 || num1== 1)
    {
        f = 0;
        break;
    }

    i++;
}
if (f == 1)
    Console.WriteLine(num1 + " is a Prime Number");
else
    Console.WriteLine(num1 + " is not a Prime Number");
//string? name = "muhammad uzair tariq ";
//int  ind =name.IndexOf(" ");
//string sub =name.Substring(ind );
//Console.WriteLine(sub);



