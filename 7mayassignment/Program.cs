// See https://aka.ms/new-console-template for more information
Console.WriteLine("assignment using if and switch statement");
// using if else conditions 
Console.Write(" enter the no to check the day using if : ");
int a = Convert.ToInt32(Console.ReadLine());


if (a == 1)
{
    Console.WriteLine(" Monday");
}
else if (a == 2)
{
    Console.WriteLine(" Tuesday");
}
else if (a == 3)
{
    Console.WriteLine(" Wednesday");
}
else if (a == 4)
{
    Console.WriteLine(" Thursday");
}
else if (a == 5)
{
    Console.WriteLine(" Friday");
}
else if (a == 6)
{
    Console.WriteLine(" Saturday");
}
else if (a == 7)
{
    Console.WriteLine(" Sunday");
}
else
{
    Console.WriteLine(" invalid input");
}
//using switch statement :
Console.Write(" enter the no again to check day using switch statement:  ");
int b = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case 1:
        Console.WriteLine(" the day is Monday");
        break;
    case 2:
        Console.WriteLine(" the day is Tuesday ");
        break;
    case 3:
        Console.WriteLine(" the day is Wednesday");
        break;
    case 4:
        Console.WriteLine(" the day is Thursday");
        break;
    case 5:
        Console.WriteLine(" the day is Friday");
        break;
    case 6:
        Console.WriteLine(" the day is Saturday");
        break;
    case 7:
        Console.WriteLine(" the day is Sunday");
        break;
    default:
        Console.WriteLine(" invalid input");
        break;
}
