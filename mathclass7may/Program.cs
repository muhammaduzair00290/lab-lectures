// See https://aka.ms/new-console-template for more information
// math class 
//Console.WriteLine("math class ");

//Console.WriteLine(" enter the value to find square root");
//;
//int a=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Sqrt(a));// to find he square root 
//Console.WriteLine(" enter the value to round ");
//float b = Convert.ToSingle(Console.ReadLine());
//Console.WriteLine(" round of value is "+Math.Round(b));// to round off the value 
//Console.WriteLine(Math.Ceiling(1.00002));// wil out put 2
//Console.WriteLine(Math.Floor(1.9));// will out put 1
// if statement 
//using System.ComponentModel.Design;

//Console.WriteLine( " enter your age ");
//int c=Convert.ToInt32(Console.ReadLine());
//if (c>=18)
//{
//    Console.WriteLine(" you are eligible for driving ");
//    Console.WriteLine($"your age is {c} press 'y if ou have a driving license 'n if ou don't have any '");
//    char? d=Convert.ToChar(Console.ReadLine()??"null");
//    if (d == 'y') 
//    {
//        Console.WriteLine(" okay jao or drive kro ");

//    }
//    else if ( d=='n')
//    {
//        Console.WriteLine(" chlo licence bnao ja ky phly ");
//    }
//    else
//    {
//        Console.WriteLine(" chal mera putter kam kt jak ky ");
//    }



//}
//else if (c==17)

//{
//    Console.WriteLine(" wait for year then you will be ");

//}
//else
//{
//    Console.WriteLine(" you are not eligible ");
//}
// ternary operator 
Console.WriteLine(" enter your age ");
int age = Convert.ToInt32(Console.ReadLine());
string result = (age >= 18) ? " you are eligible " : " you are not  eligible";// also for conditions checking 
Console.WriteLine(result);
