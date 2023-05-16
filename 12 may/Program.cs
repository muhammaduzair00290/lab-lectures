
Console.WriteLine(" enter your name ");
string? name = Console.ReadLine();

while (name.Length<8 ||name.Length>16)
{
    Console.WriteLine($"you are entering an invalid name{name} ");
    Console.WriteLine($" enter a large name   again ");
    name = Console.ReadLine();
     if (name.Length < 8 || name.Length > 16)
    {
        Console.WriteLine(" still small ");
        while (name.Length < 8 || name.Length > 16)
        {
            Console.WriteLine(" enter   again ");
            name = Console.ReadLine();
        }
        if (name.Length > 8 || name.Length < 16)
        {
            Console.WriteLine(" your name is correct ");
            Console.WriteLine(" lets move to password  ");


        }
    }
      
     else
    {
        Console.WriteLine(" shut upp ");
    }
   
    Console.WriteLine(" enter your password  ");
    string? password = Console.ReadLine();
    while(password.Length<8 || password.Length>16)
    {
        Console.WriteLine($"you are entering a wrong password {password } ");
        Console.WriteLine($" enter a large password    again ");
        password = Console.ReadLine();
        if(password.Length>8||password.Length < 16)
        {
            Console.WriteLine(" password is correct ");
            
        }
        Console.WriteLine(" enter your password again to compare   ");
        string? password1 = (Console.ReadLine());

        if (string.Equals(password, password1))
        {
            Console.WriteLine(" passwords are equal ");
            Console.WriteLine(" move to account creation");
        }

        else
        {
            Console.WriteLine(" passwords are not equal ");
            Console.WriteLine(" enter again ");
            password1 = Console.ReadLine();
            while (password!=password1)
            {
                Console.WriteLine(" enter again ");
                password1 = Console.ReadLine();
            }
        }
       

        loginPage();

    }



}

static void loginPage ()
{
    Console.WriteLine(" enter your login credentials ");
    
    Console.WriteLine(" please enter \'Y\' if you already have an account and \'N\' if you don't have any");
    char choice = Convert.ToChar(Console.ReadLine());
   
    if (choice== 'Y')
    {
        Console.WriteLine( " Sign In ");
    }
    else if (choice=='N')
    {
        Console.WriteLine(" okay then sign up ");
    }
    else
    {
        Console.WriteLine(" krna kya chahty ho");
    }
}