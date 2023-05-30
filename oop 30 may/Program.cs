 Console.Write("Enter the current time (HH:mm) >>> ");
        string? userInput = Console.ReadLine();

        if (TimeSpan.TryParse(userInput, out TimeSpan currentTime))
        {
            if (currentTime >= TimeSpan.Parse("07:00") && currentTime <= TimeSpan.Parse("07:30"))
            {
                Console.WriteLine("It's time for breakfast! ");
            }
             else if (currentTime >= TimeSpan.Parse("07:31") && currentTime <= TimeSpan.Parse("08:30"))
            {
                Console.WriteLine(" Get ready for the class ");
            }
            else if (currentTime >= TimeSpan.Parse("08:31") && currentTime <= TimeSpan.Parse("10:30"))
            {
                Console.WriteLine("its Time for Digital Marketing and SEO class ");
            }
            else if (currentTime >= TimeSpan.Parse("10:31") && currentTime <= TimeSpan.Parse("13:30"))
            {
                Console.WriteLine("It's Programming class Time  ");
            }
            else if (currentTime >= TimeSpan.Parse("13:31") && currentTime <= TimeSpan.Parse("14:30"))
            {
                Console.WriteLine("it's prayer time and do some rest  ");
            }
            else if (currentTime >= TimeSpan.Parse("14:31") && currentTime <= TimeSpan.Parse("17:30"))
            {
                Console.WriteLine("Go to lab and do some practice   ");
            }
            else if (currentTime >= TimeSpan.Parse("17:31") && currentTime <= TimeSpan.Parse("19:00"))
            {
                Console.WriteLine("  Prayer and sports time  ");

            }
            else if (currentTime >= TimeSpan.Parse("19:01") && currentTime <= TimeSpan.Parse("20:00"))
            {
                Console.WriteLine(" It's dinnertime!  ");

            }


            else if (currentTime >= TimeSpan.Parse("20:01") && currentTime <= TimeSpan.Parse("22:00"))
            {
                Console.WriteLine(" again lab with class mates :");
            }

            else if (currentTime >= TimeSpan.Parse("22:01") && currentTime <= TimeSpan.Parse("24:00") || currentTime >= TimeSpan.Parse("01:00") && currentTime <= TimeSpan.Parse("06:59"))
            {
                Console.WriteLine("  Lights off , Sleeping time  :");
            }
            else
            {
                Console.WriteLine("It's not a designated mealtime.");
            }
        }
        else
        {
            Console.WriteLine("Invalid time format. Please enter a valid time (HH:mm)");
        }
    