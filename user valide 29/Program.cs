bool isContinue = true;
while (isContinue)
{
    Console.Write("Enter a password: ");
    string? password = Console.ReadLine();

    bool isValid = ValidatePassword(password);

    if (isValid)
    {
        Console.WriteLine("Password is valid.");
        isContinue = false;
    }
    else
    {
        Console.WriteLine("Password is invalid , password can only contain letters and alphabets  and special characters .");
    }
    Console.ReadLine();
    Console.Clear();
}



static bool ValidatePassword(string password)
{
    bool hasNumber = false;
    bool hasString = false;
    bool specialCharacter = false;
    string? specialCharacters = "!@#$%^&*()_-+=<>?";
    if (password.Length >= 8)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasNumber = true;
            }
            else if (char.IsLetter(c))
            {
                hasString = true;
            }
            else if (specialCharacters.Contains(c))
            {
                return true;
            }

            if (hasNumber && hasString && specialCharacter)
            {
                return true;
            }
        }

    }
    else
    {
        Console.WriteLine(" short password try a long one of minimum 8 characters  ");
        Console.WriteLine(" enter again");
        password = Console.ReadLine();


        return true;

    }
    return false;

}
////Console.Write("Enter a password: ");
////string password = Console.ReadLine();

////bool isValid = ValidatePassword(password);

////if (isValid)
////{
////    Console.WriteLine("Password is valid.");
////}
////else
////{
////    Console.WriteLine("Password is invalid , password can only contain letters and alphabets .");
////}


////static bool ValidatePassword(string password)
////{
////    bool hasNumber = true;
////    bool hasString = true;
////    if (password.Length >= 8)
////    {
////        foreach (char c in password)
////        {
////            if (char.IsDigit(c))
////            {
////                hasNumber = true;
////            }
////            else if (char.IsLetter(c))
////            {
////                hasString = true;
////            }


////            if (hasNumber && hasString)
////            {
////                return true;
////            }
////        }

////    }
////    else
////    {
////        Console.WriteLine(" short password try a long one of minimum 8 characters  ");
////        Console.WriteLine(" enter again");
////        password = Console.ReadLine();

////        return false;

////    }
////    return true;

////}



//string string1 = "Today is " + DateTime.Now.ToString("D") + ".";
//Console.WriteLine(string1);
//string string2 = "Today is " + DateTime.Now.ToString("t") + ".";
//Console.WriteLine(string2);
//Console.WriteLine(" enter the time here ");
//DateTime dt=Convert.ToDateTime( Console.ReadLine());
//string s4=dt.ToString("t");
////Console.WriteLine(s4);
//Console.WriteLine(" enter another time ");
//DateTime dt1 = Convert.ToDateTime(Console.ReadLine());
//string s5 = dt.ToString("t");
//if (s4 == dt.ToString("t") && s5 == dt.ToString("t"))
//    {
//    Console.WriteLine(" breakfast time and get ready ");
//}
