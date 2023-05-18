//using while loop
//Console.WriteLine(" enter the string ");
//string? sentence = Console.ReadLine();
//Console.WriteLine(" enter the word to find ");
//string? wordToFind = Console.ReadLine();

//int index = -1;
//do
//{
//    index = sentence.IndexOf(wordToFind, index + 1);
//    if (index != -1)
//    {
//        Console.WriteLine($"found {wordToFind} at index {index}");
//    }
//} while (index != -1);
//{

//}
// using if else 
//Console.WriteLine(" enter the string ");
//string? sentence = Console.ReadLine();
//Console.WriteLine(" enter the word to find ");
//string? wordToFind = Console.ReadLine();

//int index = 0;
//while (index < sentence.Length)
//{
//    if (sentence.IndexOf(wordToFind, index) == -1)
//    {
//        break;
//    }
//    else
//    {
//        index = sentence.IndexOf(wordToFind, index);
//        Console.WriteLine("Found '{0}' at index {1}", wordToFind, index);
//        index += wordToFind.Length;
//    }
//}
// using for loop

//Console.WriteLine(" enter the string ");
//string? sentence = Console.ReadLine();
//Console.WriteLine(" enter the word to find ");
//string? wordToFind = Console.ReadLine();
//for (int index = 0; index <= sentence.Length; index++)
//{
//    if (sentence.IndexOf(wordToFind, index) == index)
//    {
//        Console.WriteLine($"{wordToFind} found at = {index} index "); 
//    }
   
//}
Console.WriteLine(" enter the string ");
string? sentence = Console.ReadLine();
Console.WriteLine(" enter the word to find ");
string? wordToFind = Console.ReadLine();
int index = -1;
while (true)
{
    index=sentence.IndexOf(wordToFind,++index);
    if (index == -1)
    {
        break;
    }
    Console.WriteLine($"{wordToFind} is fnd at {index} ");
}