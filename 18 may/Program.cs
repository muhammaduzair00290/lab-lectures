int[] numbers = { 2, -5, 6, -8, 0, -3, 9, -1 };

int count = CountNegativeElements(numbers);

Console.WriteLine("Number of negative elements: " + count);


static int  CountNegativeElements(int[] array)
{
    int count = 0;

    foreach (int number in array)
    {
        if (number < 0)
        {
            count++;
        }
    }

    return count;
}
//int[] numbers = { 2, -5, 6, -8, 0, -3, 9, -1 };

//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine("Number of negative elements: " + count);