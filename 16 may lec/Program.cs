
Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String? response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);
    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
    while (guess != number)
    {
      
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine($"{guess}   is  higher then  number !");
        }
        else if (guess < number)
        {
            Console.WriteLine($" {guess}  is  lower than number !");
        }
        guesses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: " + guesses);

    Console.WriteLine("Would you like to play again (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Thanks for playing! ... Chlo so jao ja ky ");

Console.ReadKey();
Console.WriteLine(" you are pro bro");
        