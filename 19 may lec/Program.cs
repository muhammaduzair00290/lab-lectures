//Console.WriteLine(" enter a text1 here  ");
//string? t1 =Console.ReadLine();
//Console.WriteLine(" enter text 2 here ");
//string? t2 =Console.ReadLine();
//if (t1.ToLower().Equals(t2.ToLower()))
//{
//    Console.WriteLine($"{t1} is equal to {t2} ");

//}
//else
//{
//    Console.WriteLine(" not equal ");
//}
//Console.WriteLine(" enter a text1 here  ");
//string? t1 = Console.ReadLine();
//Console.WriteLine(" enter text 2 here ");
//string? t2 = Console.ReadLine();
//if (t1.Equals(t2,StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine($"{t1} is equal to {t2} ");

//}
//else
//{
//    Console.WriteLine(" not equal ");
//}
// split 
//string name = " ali,rehman,kamran,yasir,haseeb  ";
// string [] names =name.Split(",");
////Console.WriteLine(names);// cannot out put array like this . is trha uski class show hogi system.string() .
//int i = 0;
//foreach(string  item  in names)
//{
//    Console.WriteLine($"at {++i} student name is  {item}");
//}

// date time 
//DateTime dateTime = DateTime.Now;
//Console.WriteLine(dateTime);
//DateTime dt = new DateTime(2023,2,6);
//Console.WriteLine(dt.Year);
//Console.WriteLine(dt.Month);
//Console.WriteLine(dt.Day);
//Console.WriteLine(dt.DayOfWeek);
//Console.WriteLine(dt.Hour);
//Console.WriteLine(dt.Minute);
//Console.WriteLine(dt.Second);

//DateTime dt = DateTime.Now;
//Console.WriteLine($"year {dt.Year} month {dt.Month} day {dt.Day} hour {dt.Hour} minute {dt.Minute}");
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(" enter date in yyyy-MM-DD");
//DateTime dt1=Convert.ToDateTime(Console.ReadLine());
////Console.WriteLine(($"year {dt1.Year} month {dt1.Month} day {dt1.Day}  week day {dt1.DayOfWeek} hour  {dt1.Hour} minute {dt1.Minute}"));
//string d = dt1.ToShortDateString();
//string d1 = dt1.ToLongDateString();
// string d3=dt1.ToString(" dd-yyyy-MM-H:m:s:tt:U" );
//Console.WriteLine(d + " " + d1);
//Console.WriteLine(d3);


//using System.Transactions;

//Console.WriteLine(" enter the day to check the routine ");
//string  choice = Convert.ToString((Console.ReadLine() ?? "0"));

//switch (choice)
//{
//    case "Monday":
//        Console.WriteLine(" your routine for the day is ");
//        MondayRoutine();
//        break;
//    case "Tuesday":
//        Console.WriteLine(" your routine for Tuesday is ");
//        break;
//    case "Wednesday":
//        Console.WriteLine(" your routine for the Wednesday  is ");
//        break;
   
//    case "Thursday":
//        Console.WriteLine(" your routine for the Thursday  is ");
//        break;
//    case "":
//        Console.WriteLine(" your routine for the Friday  is ");
//        break;
//    case "Friday":
//        Console.WriteLine(" your routine for the Friday  is ");
//        break;
//    default:
//        Console.WriteLine(" enter a valid value ");
//        break;

//}
//static  void MondayRoutine()
//{
  


//}
//Console.WriteLine(" enter the time to check the activity ");
//DateTime d1=DateTime.Today;
//Console.WriteLine(" enter day ");
//string? d2=d1.ToString("dddd" );
//d2=Console.ReadLine();
//int time=Convert.ToInt32(Console.ReadLine());
//if (d2=="Monday")
{
    //Console.WriteLine(" you are good ");
    //Console.WriteLine(" this is your DRO for the day ");

}
//if (d1.DayOfWeek == DayOfWeek.Monday)
//{
//    if (time==7 && time<=8)
//    {
//        Console.WriteLine( " this is breakfast time and to ready for the assembly");
//    }
//     else if() 
//}
Console.WriteLine(" enter the time ");
DateTime currentTime = DateTime.Now;
Console.WriteLine(currentTime);
if (currentTime.Hour < 12)
{
    Console.WriteLine("Good morning!");
}
else if (currentTime.Hour < 18)
{
    Console.WriteLine("Good afternoon!");
}
else
{
    Console.WriteLine("Good evening!");
}



