//DateTime dt = DateTime.Now;
//Console.WriteLine($"{dt.Year} {dt.Day} {dt.Month}");
DateTime dt1 = DateTime.Now;
Console.WriteLine(dt1.Year);
Console.WriteLine(dt1.Month);
Console.WriteLine(dt1.Day);
// for adding months 
 DateTime dt2=  dt1.AddMonths(14);
Console.WriteLine(dt2);
// for days 
DateTime dt3=dt1.AddDays(111);
Console.WriteLine(dt3);
// hours adding 
DateTime dt4 = dt1.AddHours(12);
Console.WriteLine(dt4);