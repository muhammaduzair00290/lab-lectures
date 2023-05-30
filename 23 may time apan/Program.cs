Console.WriteLine(" enter start date ");
DateTime sc = Convert.ToDateTime(Console.ReadLine());
DateTime dt = DateTime.Today;
TimeSpan ts = dt.Subtract(sc);

Console.WriteLine($"{ts.TotalDays}");
Console.WriteLine($"{ts.TotalHours}");
Console.WriteLine($"{ts.TotalMinutes}");
Console.WriteLine($"{ts.TotalSeconds}");
int years = (int)(ts.TotalDays / 365.25);
Console.WriteLine($" you are {years} years old ");
int months = years * 12;
Console.WriteLine($" and  you lived {months}  months");
float weeks = (float)365.25 / 7.0f;
//Console.WriteLine(weeks);
int tw = (int)(years * weeks);
Console.WriteLine( $" and total weeks {tw}");


//Console.WriteLine(" enter your date of birth ");
//DateTime dob = Convert.ToDateTime(Console.ReadLine());
//DateTime td = DateTime.Today;
//TimeSpan ab = td.Subtract(dob);
//Console.WriteLine(ab.TotalDays);
//int yea = (int)(ab.TotalDays / 365.25);
//Console.WriteLine(yea);
//int mon = (int)(ab.TotalDays % 365.25) / 31;// for calculating the exact months after the total years : like 21 years and 4 months ;
//Console.WriteLine(mon);



//>>>>>>>>>>>>>>>>>>>>> ENUM <<<<<<<<<<<<<<<<<<<<<<
DayOfWeek day = DayOfWeek.Saturday;
if (day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
{
    Console.WriteLine("its not a working day  ");

}
else
{
    Console.WriteLine(" chlo kam ty ");
}

