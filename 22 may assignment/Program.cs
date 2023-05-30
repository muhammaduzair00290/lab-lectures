// 1: program to count  no of words in a give string :

//Console.WriteLine( " enter  a string to calculate the no of words ");
//string? str =Console.ReadLine();
//int count = countWords(str);
//Console.WriteLine($"No of words are {count} ");

//static int countWords(string str)
//{
//    string[] words = str.Split(new[] { ' ', '\t', '\n',  }, StringSplitOptions.RemoveEmptyEntries);
//    return words.Length;
//}
// 2: program to count the words of two strings ;




//Console.WriteLine(" enter the string ");
//string? sentence = Console.ReadLine();
//Console.WriteLine(" enter the word to find ");
//string? wordToFind = Console.ReadLine();
//int c = 0;
//for (int index = 0; index <= sentence.Length; index++)
//{
//    if (sentence.IndexOf(wordToFind, index) == index)
//    {
//        Console.WriteLine($"{wordToFind} found at = {index} index ");
//        c++;
//    }

//}
//Console.WriteLine($" for for {c} times ");



//to remove extra wide spaces :
// variables;
//string? userInput, askIsContinue;
//bool isContinue = true;
////Code
//while (isContinue)
//{
//    Console.WriteLine("Enter the string  Here");
//    Console.Write(">>");
//    userInput = Console.ReadLine();
//    while (userInput.Contains("  "))
//    {
//        userInput = userInput.Replace("  ", " ");
//    }
//    Console.WriteLine($"ExtraSpaces are Removed From The String \"{userInput}\"");
//    Console.Write("Do You want To restart?(y/n): ");
//    askIsContinue = Console.ReadLine();
//    if (askIsContinue.ToLower() == "y")
//        isContinue = true;

//    else   if (askIsContinue.ToLower() == "n")
//    {
//        isContinue = false;
//        Console.Clear();
//    }
//    else
//    {
//        Console.WriteLine(" ja kam kr ja ky ");
//    }
//    Console.Clear();
//}
// program to replace one character eith the other one 
