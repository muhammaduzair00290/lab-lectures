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
Console.WriteLine(" enter date in yyyy-MM-DD");
DateTime dt1=Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine(($"year {dt1.Year} month {dt1.Month} day {dt1.Day}  week day {dt1.DayOfWeek} hour  {dt1.Hour} minute {dt1.Minute}"));
string d = dt1.ToShortDateString();
string d1 = dt1.ToLongDateString();
 string d3=dt1.ToString(" dd-yyyy-MM-H:m:s:tt:U" );
Console.WriteLine(d + " " + d1);
Console.WriteLine(d3);
