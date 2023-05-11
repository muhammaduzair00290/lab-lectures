// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//// substring 
// Full name
//string name = "uzair ali";

//// Location of the letter D
//int charPos = name.IndexOf(" ");

//// Get last name
//string lastName = name.Substring(charPos);

//// Print the result
//Console.WriteLine(lastName);
// strings methods 
//string? name1 = " uzair tariq";
//string? name2 = " software developer";
//Console.WriteLine(name1.ToUpper());
//Console.WriteLine(name1.ToLower());
//Console.WriteLine(name1[4]);
//Console.WriteLine(name1.IndexOf("z"));
//Console.WriteLine(string.Concat(name1, name2));
//Console.WriteLine(" hello \" uzair \" bhaii");
//Console.WriteLine(" hello \t bhaii");
//Console.WriteLine(" hello \n bhaii");
//Console.WriteLine(" hello \b bhaii");
// while loop :
//int i = 10;
//while (i >= 5)
//{
//    Console.WriteLine(i);
//    i--;
//}
// do while loop
//int b = 1;
//do
//{
//    Console.WriteLine(b);
//    b++;
//}
//while (b < 15);
//int a = 1;
//int b = 3;
//while (a <= 10)
//{

//    Console.WriteLine(b + " * " + a + " = " + b * a);

//    a++;

//}
//int a = 6;//starting value
//int b = 8;//ending value
//while (a <= b)
//{
//    int i = 1;
//    while (i <= 10)
//    {
//        Console.WriteLine($"{a} x {i} = {a * i}");
//        i++;
//    }
//    a++;
//}
// program to print multiple tables range :
//Console.WriteLine(" enter the starting number ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(" enter the ending value ");
//int b = Convert.ToInt32(Console.ReadLine());
//while (a <= b)
//{
//    int c = 1;
//    while (c <= 10)
//    {
//        Console.WriteLine($"{a}*{c} ={a * c} ");
//        c++;
//    }
//    a++;
//}
//Console.WriteLine(" enter the no to check ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine($"{num} is even ");

//}
//else
//{
//    Console.WriteLine(" the no is odd ");
//    }

//Console.Write("Enter any number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//int f = 0;
//int i = 2;
//while (i <= num1 / 2)
//{
//    if (num1 % i == 0)
//    {
//        f = 1;
//        break;
//    }
//    i++;
//}
//if (f == 0)
//    Console.WriteLine(num1 + " is a Prime Number");
//else
//    Console.WriteLine(num1 + " is not a Prime Number");

Console.Write("Enter any number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int f = 0;
int i = 2;
while (i < num1 / 2)
{
    if (num1 % i == 0)
    {
        f = 1;
        break;
    }
    i++;
}
if (f == 0)
    Console.WriteLine(num1 + " is a Prime Number");
else
    Console.WriteLine(num1 + " is not a Prime Number");

//Console.Write("Enter any number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//int f = 1;
//int i = 2;
//while (i < num1 || num1 ==1)
//{
//    if (num1 == 1)
//    {
//        f = 0;
//        break;
//    }
//    if (num1 % i == 0 )
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
