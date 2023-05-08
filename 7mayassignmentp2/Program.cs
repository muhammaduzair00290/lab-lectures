// See https://aka.ms/new-console-template for more information
Console.WriteLine("assignment program 2 using if and switch");

Console.Write(" enter the no to check the flavor using if : ");
int flavor  = Convert.ToInt32(Console.ReadLine());


if (flavor == 1)
{
    Console.WriteLine("Chicken Fajita ");
}
else if (flavor == 2)
{
    Console.WriteLine(" Chicken Tikka");
}
else if (flavor == 3)
{
    Console.WriteLine("BBQ Pizza ");
}
else if (flavor == 4)
{
    Console.WriteLine(" Pepperoni");
}
else if (flavor == 5)
{
    Console.WriteLine(" Malai Boti");
}
else if (flavor == 6)
{
    Console.WriteLine(" Veggie pizza");
}
else if (flavor == 7)
{
    Console.WriteLine("Hot & Spicy ");
}
else
{
    Console.WriteLine(" required flavor is not available ");
}
//using switch statement :
Console.Write(" enter the no again to check flavor  using switch statement:  ");
int b = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case 1:
        Console.WriteLine(" Chicken Fajita");
        break;
    case 2:
        Console.WriteLine("Chicken Tikka  ");
        break;
    case 3:
        Console.WriteLine(" BBQ Pizza");
        break;
    case 4:
        Console.WriteLine(" Pepperoni");
        break;
    case 5:
        Console.WriteLine(" Malai Boti");
        break;
    case 6:
        Console.WriteLine(" Veggie pizza");
        break;
    case 7:
        Console.WriteLine("Hot & Spicy");
        break;
    default:
        Console.WriteLine(" flavor is not available ");
        break;
}


