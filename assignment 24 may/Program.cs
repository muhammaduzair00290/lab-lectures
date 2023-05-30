// program no 1: 

//Console.WriteLine(" enter your date of birth ");
//DateTime dob = Convert.ToDateTime(Console.ReadLine());
//DateTime td = DateTime.Today;
//TimeSpan ab = td.Subtract(dob);
//Console.WriteLine(ab.TotalDays);
//int yea = (int)(ab.TotalDays / 365.25);
//Console.WriteLine($" your age is {yea}");
//if (yea >=0 && yea<=10)
//{
//    Console.WriteLine(" you are a \"child\" ");
//}
//else if (yea >=11 &&  yea<=18)
//{
//    Console.WriteLine(" you are a \"Boy\"");
//}
//else if (yea >=19 && yea<=40)
//{
//    Console.WriteLine(" you are \"Adult\"");

//}
//else if(yea >=41&& yea<=90)
//{
//    Console.WriteLine(" you are \"old\"");
//}
//else
//{
//    Console.WriteLine( " invalid age ");
//}

// program no 2:

//Console.WriteLine(" enter the date ");
//DateTime dt = Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine(" enter the next days to find ");

DateTime ds = new DateTime(2023, 5 , 23 );
DateTime res = ds.AddDays(5);

string? dayname =res.DayOfWeek.ToString();
Console.WriteLine($"after adding the 5 days {res}");
Console.WriteLine($" the current  day  after adding days {dayname}");


// program no 3 :


Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
DateTime dateAndTime = DateTime.Today;
DateTime yearsAdd = dateAndTime.AddYears(15);
DateTime daysAdd = dateAndTime.AddDays(13);
Console.WriteLine($"Today {dateAndTime:d}");
Console.WriteLine($"After 15 Days {daysAdd:d} Name is : {daysAdd.DayOfWeek} Year Day {daysAdd.DayOfYear} ");
Console.WriteLine($"Finally {daysAdd:D}");


// program no 4 :



Console.WriteLine("Enter First Date (yyyy-MM-dd:");
DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter Second Date (yyyy-MM-dd:");
DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

int n = 0;
while (true)
{
    if (firstDate.AddDays(n) == secondDate)
    {
        break;
    }
    n++;
    Console.WriteLine($"{firstDate.AddDays(n)} and day is {firstDate.AddDays(n).DayOfWeek}");
}
