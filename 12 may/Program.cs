Console.WriteLine(" enter your name ");
string? name = Console.ReadLine();

while (name.Length<8 ||name.Length>16)
{
    Console.WriteLine($"you are entering an invalid name{name} ");
    Console.WriteLine($" enter a large name   again ");
    name = Console.ReadLine();
    if (name.Length > 8 || name.Length < 16)
    {
        Console.WriteLine(" your name is correct ");
        Console.WriteLine(" lets move to password  ");


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
            Console.WriteLine(" move to account creation");
        }
        loginPage();

    }



}

static void loginPage ()
{
    Console.WriteLine(" enter your login credentials ");
    string? login= Console.ReadLine();
}